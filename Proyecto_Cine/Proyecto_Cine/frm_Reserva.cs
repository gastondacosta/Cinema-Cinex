using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace Proyecto_Cine
{
    public partial class frm_Reserva : Form
    {
        public frm_Reserva()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void ListarDetalle()
        {
            dgv_Detalle.DataSource = null;
            dgv_Detalle.DataSource = (from item in listRes
                                     join funcion in db.Funcions
                                     on item.IdFuncion equals funcion.IDFUNCION
                                     join tipoEntra in db.Tipo_Entradas
                                     on item.IdTipoEntrada equals tipoEntra.IDTIPOENTRADA
                                     select new {Cliente = item.Nombre, Pelicula = item.NombrePelicula, Cine = item.NombreCine, Sala = item.NumeroSala, Fecha = funcion.FECHAFUNCION, Butaca = item.IdButaca, Entrada = tipoEntra.NOMBRE, Precio = item.Precio}).ToList();
        }
        public decimal SumarPrecios(List<Reservas> listRes)
        {
            int nElementos = listRes.Count();
            decimal suma = 0;
            for (int i =0; i < nElementos; i++)
            {
                suma += listRes[i].Precio;
            }
            return suma;
        }
        private void btn_BuscarEmpleado_Click(object sender, EventArgs e)
        {
            frm_PopUp_Reserva_BuscarEmpleado popBE = new frm_PopUp_Reserva_BuscarEmpleado();
            popBE.ShowDialog();

            if (popBE.DialogResult == DialogResult.OK)
            {
                txt_CodigoEmpleado.Text = popBE.Id;
                txt_NombreEmpleado.Text = popBE.NombreCompleto;
            }
        }

        private void btn_BuscarDniCliente_Click(object sender, EventArgs e)
        {
            frm_PopUp_Reserva_BuscarCliente popBC = new frm_PopUp_Reserva_BuscarCliente();
            popBC.ShowDialog();

            if (popBC.DialogResult == DialogResult.OK)
            {
                txt_DniCliente.Text = popBC.IdC;
                txt_NombreCliente.Text = popBC.NombreCompleto;
            }
        }

        private void frm_Reserva_Load(object sender, EventArgs e)
        {
            cbo_Cine.DataSource = db.Cines.Where(x => x.HABILITADO.Equals(true)).ToList();
            cbo_Cine.ValueMember = "IDCINE";
            cbo_Cine.DisplayMember = "NOMBRE";
        }

        private void cbo_Cine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_Cine.SelectedValue != null)
            {

                var consulta = (from funcion in db.Funcions
                                      join peli in db.Peliculas
                                      on funcion.IDPELICULA equals peli.IDPELICULA
                                      where funcion.IDCINE.Equals(cbo_Cine.SelectedValue) // && Convert.ToDateTime(funcion.FECHAFUNCION) > DateTime.Now
                                      select new PeliculaC {IdPel = peli.IDPELICULA, TituloP = peli.TITULO}).Distinct().ToList();
                if (consulta.Count == 0)
                {
                    cbo_Funcion.DataSource = null;
                    txt_Sala.Text = "";
                    cbo_TipoE.DataSource = null;
                    txt_Precio.Text = "";
                }
                cbo_Peli.DataSource = consulta;
                //cbo_Peli.Text = "";
                cbo_Peli.ValueMember = "IdPel";
                cbo_Peli.DisplayMember = "TituloP";
            }
        }

        private void cbo_Peli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_Peli.SelectedValue != null)
            {
                var consulta = (from funcion in db.Funcions
                                          where funcion.IDPELICULA.Equals(cbo_Peli.SelectedValue) && funcion.IDCINE.Equals(cbo_Cine.SelectedValue) // && Convert.ToDateTime(funcion.FECHAFUNCION) > DateTime.Now
                                          select new FuncionC{ IdFuncion = funcion.IDFUNCION, FechaFuncion = Convert.ToDateTime(funcion.FECHAFUNCION)}).ToList();
                cbo_Funcion.DataSource = consulta;
                cbo_Funcion.ValueMember = "IdFuncion";
            }
        }

        private void cbo_Funcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_Funcion.SelectedValue != null)
            {
                int idFuncionp = ((Funcion)cbo_Funcion.SelectedItem).IDFUNCION; //?
                var consulta = (from funcion in db.Funcions
                                join sala in db.Salas
                                on funcion.IDSALA equals sala.IDSALA
                               where funcion.IDFUNCION.Equals(idFuncionp)
                            select sala.IDSALA).ToList();
                foreach (var item in consulta)
                {
                    txt_Sala.Text = item.ToString();
                }

                //?
                var consultaB = (from butaca in db.Butacas
                                 join funcion in db.Funcions
                                 on butaca.IDFUNCION equals funcion.IDFUNCION
                                 where butaca.HABILITADO.Equals(true) && funcion.IDFUNCION.Equals(idFuncionp)
                                 select new { butaca.IDFUNCION, butaca.IDBUTACA, butaca.LIBRE, butaca.INDICE_FILA, butaca.INDICE_COLUMNA}).ToList();
                dgv_Butacas.DataSource = consultaB;

                //
                var consultaT = (from funcionE in db.Funcion_Entradas
                                 join tipoE in db.Tipo_Entradas
                                 on funcionE.IDTIPOENTRADA equals tipoE.IDTIPOENTRADA
                                 where funcionE.IDFUNCION.Equals(idFuncionp) && funcionE.HABILITADO.Equals(true)
                                 select new TipoEntrada { IdTipoEntrada = tipoE.IDTIPOENTRADA, Nombre=tipoE.NOMBRE }).ToList();
                cbo_TipoE.DataSource = consultaT;
                cbo_TipoE.DisplayMember = "Nombre";
                cbo_TipoE.ValueMember = "IdTipoEntrada";
            } 
        }

        private void cbo_TipoE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_TipoE.SelectedValue != null)
            {
                int idFunc = ((Funcion)cbo_Funcion.SelectedItem).IDFUNCION;
                int tipoEntrada = ((Tipo_Entrada)cbo_TipoE.SelectedItem).IDTIPOENTRADA;
                var consulta = (from funcion in db.Funcions
                               join funcione in db.Funcion_Entradas
                               on funcion.IDFUNCION equals funcione.IDFUNCION
                               where funcione.IDFUNCION.Equals(idFunc) && funcione.IDTIPOENTRADA.Equals(tipoEntrada) && funcione.HABILITADO.Equals(true)
                               select new
                               {
                                   funcione.PRECIO
                               }).ToList();
                foreach (var item in consulta)
                {
                    txt_Precio.Text = item.PRECIO.ToString();
                }
            }
        }

        List<Reservas> listRes = new List<Reservas>();
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea agregar esta reserva?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (!String.IsNullOrWhiteSpace(txt_DniCliente.Text) && !String.IsNullOrWhiteSpace(txt_NombreCliente.Text) && !String.IsNullOrWhiteSpace(cbo_Cine.Text) && !String.IsNullOrWhiteSpace(cbo_Funcion.Text) && !String.IsNullOrWhiteSpace(txt_Sala.Text))
                {
                    var consulta = db.Reservas.ToLookup(x => x.IDRESERVA).Count();
                    int idCliente = Convert.ToInt32(txt_DniCliente.Text);
                    int idFuncion = ((Funcion)cbo_Funcion.SelectedItem).IDFUNCION;
                    int idButaca = Convert.ToInt32(dgv_Butacas.CurrentRow.Cells[5].Value);
                    int idTipoEntrada = ((Tipo_Entrada)cbo_TipoE.SelectedItem).IDTIPOENTRADA;
                    decimal precio = Convert.ToDecimal(txt_Precio.Text);
                    string nombreCliente = txt_NombreCliente.Text;
                    DateTime fechaFuncion = Convert.ToDateTime(((Funcion)cbo_Funcion.SelectedItem).FECHAFUNCION); //hay que agregarle hora tmb a la fecha
                    string nombreCine = ((Cine)cbo_Cine.SelectedItem).NOMBRE;
                    string nombrePelicula = ((Pelicula)cbo_Peli.SelectedItem).TITULO;
                    int numeroSala = Convert.ToInt32(txt_Sala.Text);
                    Reservas reser = new Reservas
                    {
                        IdCliente = idCliente,
                        IdFuncion = idFuncion,
                        IdButaca = idButaca,
                        IdTipoEntrada = idTipoEntrada,
                        Precio = precio,
                        Nombre = nombreCliente,
                        FechaFuncion = fechaFuncion,
                        NombreCine = nombreCine,
                        NombrePelicula = nombrePelicula,
                        NumeroSala = numeroSala
                    };

                    var consultaButaca = (from item in listRes
                                         where item.IdFuncion.Equals(idFuncion) && item.IdButaca.Equals(idButaca)
                                         select item).ToList();
                    int nButacas = consultaButaca.Count();
                    if (nButacas >=1)
                    {
                        MessageBox.Show("La butaca que eligió ya ha sido seleccionada");
                        return;
                    }

                    listRes.Add(reser);
                    ListarDetalle();
                    decimal suma = SumarPrecios(listRes);
                    txt_PrecioFinal.Text = suma.ToString();
                }
                else
                {
                    MessageBox.Show("Complete los campos faltantes");
                    return;
                }
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            DateTime fechaFuncion = (DateTime)dgv_Detalle.CurrentRow.Cells[4].Value;
            string nombreCompleto = dgv_Detalle.CurrentRow.Cells[0].Value.ToString();
            listRes.RemoveAll(x=>x.FechaFuncion.Equals(fechaFuncion) && x.Nombre.Equals(nombreCompleto));
            ListarDetalle();
            decimal suma = SumarPrecios(listRes);
            txt_PrecioFinal.Text = suma.ToString();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = Convert.ToInt32(txt_DniCliente.Text);
                int idEmpleado = Convert.ToInt32(txt_CodigoEmpleado.Text);
                decimal total = Convert.ToDecimal(txt_PrecioFinal.Text);
                using (var transaccion = new TransactionScope())
                {
                    Reserva res = new Reserva()
                    {
                        IDCLIENTE = idCliente,
                        IDEMPLEADO = idEmpleado,
                        TOTAL = total,
                        HABILITADO = true,
                    };
                    db.Reservas.InsertOnSubmit(res);
                    db.SubmitChanges();

                    int idReserva = res.IDRESERVA;
                    int nListaReserva = listRes.Count();
                    for (int i = 0; i > nListaReserva; i++) //revisar
                    {
                        int idFun = listRes[i].IdFuncion;
                        int idBut = listRes[i].IdButaca;
                        Detalle_Reserva detRes = new Detalle_Reserva()
                        {
                            IDRESERVA = idReserva,
                            IDCLIENTE = listRes[i].IdCliente,
                            PRECIO = Convert.ToInt32(listRes[i].Precio),
                            IDFUNCION = listRes[i].IdFuncion,
                            IDBUTACA = listRes[i].IdButaca,
                            HABILTIADO = true
                        };
                        db.Detalle_Reservas.InsertOnSubmit(detRes);

                        var butaca = db.Butacas.Where(x => x.IDFUNCION.Equals(idFun) && x.IDBUTACA.Equals(idBut));
                        foreach (var item in butaca)
                        {
                            item.LIBRE = false;
                        }
                    }
                    db.SubmitChanges();
                    transaccion.Complete();

                
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
                MessageBox.Show(ex.Message);
                DialogResult = DialogResult.None;
            }
        }
    }
}
