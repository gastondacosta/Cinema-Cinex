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
    public partial class frm_PopUp_Funcion : Form
    {
        public frm_PopUp_Funcion()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        List<Entrada> listaEntrada = new List<Entrada>();
        public string Titulo { get; set; }
        public string Subtitulo { get; set;}
        public int Id { get; set; }
        private void frm_PopUp_Funcion_Load(object sender, EventArgs e)
        {
            this.Text = Titulo;
            lbl_Subtitulo.Text = Subtitulo;

            cbo_Pelicula.DataSource = db.Peliculas;
            cbo_Pelicula.DisplayMember = "TITULO";
            cbo_Pelicula.ValueMember = "IDPELICULA";
            cbo_Pelicula.SelectedIndex = -1;

            cbo_Cine.DataSource = db.Cines;
            cbo_Cine.DisplayMember = "NOMBRE";
            cbo_Cine.ValueMember = "IDCINE";
            cbo_Cine.SelectedValue = 1;

            cbo_tipo.DataSource = db.Tipo_Entradas;
            cbo_tipo.DisplayMember = "NOMBRE";
            cbo_tipo.ValueMember = "IDTIPOENTRADA";

            if (Titulo == "Editar")
            {
                var consulta = db.Funcions.Where(x => x.IDFUNCION.Equals(Id)).ToList();
                foreach (Funcion f in consulta)
                {
                    txt_fecha.Value = Convert.ToDateTime(f.HORARIO);
                    txt_horario.Text = f.HORARIO;
                    cbo_Pelicula.SelectedValue = f.IDPELICULA;
                    cbo_Cine.SelectedValue = f.IDCINE;
                    cbo_Sala.SelectedValue = f.IDSALA;
                }
            }
        }
        private void cbo_Cine_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void cbo_Cine_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            string fecha = txt_fecha.Text;
            int idPelicula = ((Pelicula)cbo_Pelicula.SelectedItem).IDPELICULA;
            int idCine = ((Cine)cbo_Cine.SelectedItem).IDCINE;
            int idSala = ((Sala)cbo_Sala.SelectedItem).IDSALA;
            string horario = txt_horario.Text;

            if (Titulo == "Agregar")
            {
                if (!String.IsNullOrWhiteSpace(txt_horario.Text) && !String.IsNullOrWhiteSpace(cbo_Pelicula.Text) && !String.IsNullOrWhiteSpace(cbo_Cine.Text) && !String.IsNullOrWhiteSpace(cbo_Sala.Text))
                {
                    if (!(dgv_precios.Rows.Count.Equals(0)))
                    {
                        if (MessageBox.Show("Seguro que desea agregar la función?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            //Funcion
                            var consulta = db.Funcions.ToLookup(x => x.IDPELICULA).Count();
                            try
                            {
                                using (var transaccion = new TransactionScope())
                                {
                                    //Grabacion de la funcion
                                    Funcion fun = new Funcion
                                    {
                                        IDFUNCION = consulta + 1,
                                        FECHAFUNCION = fecha,
                                        IDPELICULA = idPelicula,
                                        IDCINE = idCine,
                                        IDSALA = idSala,
                                        HABILITADO = true,
                                        HORARIO = horario
                                    };
                                    db.Funcions.InsertOnSubmit(fun);
                                    db.SubmitChanges();
                                    

                                    //Butacas
                                    int idFuncion = fun.IDFUNCION;
                                    var consulta1 = db.Salas.Where(x => x.IDSALA.Equals(idSala)).ToList();
                                    int filas = 0;
                                    int columnas = 0;
                                    foreach (Sala sa in consulta1)
                                    {
                                        filas = (int)sa.CANT_FILAS;
                                        columnas = (int)sa.CANT_COLUMNAS;
                                    }

                                    int c = 1;
                                    for (int x = 1; x <= filas; x++)
                                    {
                                        for (int y = 1; y <= columnas; y++)
                                        {
                                            Butaca but = new Butaca
                                            {
                                                IDFUNCION = idFuncion,
                                                IDBUTACA = c,
                                                INDICE_COLUMNA = y,
                                                INDICE_FILA = x,
                                                HABILITADO = true,
                                                LIBRE = true
                                            };
                                            db.Butacas.InsertOnSubmit(but);
                                            c++;
                                        }
                                    }
                                    db.SubmitChanges();

                                    //Guardar Tipos Entrada
                                    int nListas = listaEntrada.Count;
                                    // from panchos in db.panchos
                                    var consulta3 = db.Funcion_Entradas.ToLookup(x => x.IDENTRADA).Count();
                                    for (int i = 0; i < nListas; i++)
                                    {
                                        Funcion_Entrada fe = new Funcion_Entrada
                                        {
                                            IDENTRADA = ++consulta3,
                                            IDFUNCION = idFuncion,
                                            IDTIPOENTRADA = listaEntrada[i].idTipoEntrada,
                                            PRECIO = listaEntrada[i].precio,
                                            HABILITADO = true
                                        };
                                        db.Funcion_Entradas.InsertOnSubmit(fe);
                                    }
                                    db.SubmitChanges();
                                    transaccion.Complete();
                                    MessageBox.Show("Se ha agregado con éxito");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("No se ha podido agregar");
                                MessageBox.Show(ex.Message);
                                MessageBox.Show(ex.StackTrace);
                                MessageBox.Show(ex.InnerException.ToString());
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese los precios");
                        DialogResult = DialogResult.None;
                    }
                }
                else
                {
                    MessageBox.Show("Complete todos los campos");
                    DialogResult = DialogResult.None;
                }
            }

            if (Titulo == "Editar")
            {
                if (!String.IsNullOrWhiteSpace(txt_horario.Text) && !String.IsNullOrWhiteSpace(cbo_Pelicula.Text) && !String.IsNullOrWhiteSpace(cbo_Cine.Text) && !String.IsNullOrWhiteSpace(cbo_Sala.Text))
                {
                    if (MessageBox.Show("Seguro que desea editar la función?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        var consulta = db.Funcions.Where(x => x.IDFUNCION.Equals(Id)).ToList();
                        foreach (Funcion fx in consulta)
                        {
                            fx.HORARIO = txt_horario.Text;
                            fx.FECHAFUNCION = txt_fecha.Text;
                            fx.IDSALA = Convert.ToInt32(cbo_Sala.SelectedValue);
                            fx.IDCINE = Convert.ToInt32(cbo_Cine.SelectedValue);
                            fx.IDPELICULA = Convert.ToInt32(cbo_Pelicula.SelectedValue);
                        }
                        try
                        {
                            db.SubmitChanges();
                            MessageBox.Show("Se ha editado correctamente");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se ha podido editar");
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Complete todos los campos");
                    DialogResult = DialogResult.None;
                }
            }
        }

        private void cbo_Cine_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCine = ((Cine)cbo_Cine.SelectedItem).IDCINE;
            var consulta = db.Salas.Where(x => x.IDCINE.Equals(idCine)).ToList();

            cbo_Sala.DataSource = consulta;
            cbo_Sala.DisplayMember = "IDSALA";
            cbo_Sala.ValueMember = "IDSALA";
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            int idTipoEntrada = ((Tipo_Entrada)cbo_tipo.SelectedItem).IDTIPOENTRADA;
            string nombreTipo = ((Tipo_Entrada)cbo_tipo.SelectedItem).NOMBRE;
            decimal precio = nud_Precio.Value;
            dgv_precios.DataSource = null;

            if (precio <=0)
            {
                MessageBox.Show("El precio debe ser mayor a 0");
                return;
            }
            var consulta = listaEntrada.Where(x => x.idTipoEntrada.Equals(idTipoEntrada)).Count();
            if (consulta > 0)
            {
                MessageBox.Show("Ya se registro este tipo de entrada");
                return;
            }
            else
            {
                listaEntrada.Add(new Entrada { idTipoEntrada = idTipoEntrada, nombreTipo = nombreTipo, precio = precio });
                dgv_precios.DataSource = listaEntrada.ToList();
            }
        }
    }
}
