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
                listaEntrada = (from fune in db.Funcion_Entradas
                               join tipoe in db.Tipo_Entradas
                               on fune.IDTIPOENTRADA equals tipoe.IDTIPOENTRADA
                                where fune.IDFUNCION.Equals(Id) && fune.HABILITADO.Equals(true)
                               select new Entrada { idTipoEntrada = fune.IDTIPOENTRADA, nombreTipo = tipoe.NOMBRE, precio = Convert.ToDecimal(fune.PRECIO) }).ToList();
                dgv_precios.DataSource = listaEntrada;

                dgv_precios.Columns[0].Visible = false;
                dgv_precios.Columns[1].HeaderText = "Tipo de entrada";
                dgv_precios.Columns[2].HeaderText = "Precio";
                for (int i = 0; i <= dgv_precios.Columns.Count - 1; i++)
                {
                    dgv_precios.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
                            var consulta = db.Funcions.Max(x => x.IDFUNCION);
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

                                    int c = 1; //en la base de datos ya tengo butacas con este numero
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
                        try
                        {
                            using (var transaccion = new TransactionScope())
                            {
                                var consulta = db.Funcions.Where(x => x.IDFUNCION.Equals(Id)).ToList();
                                foreach (Funcion fx in consulta)
                                {
                                    fx.HORARIO = horario;
                                    fx.FECHAFUNCION = fecha;
                                    fx.IDSALA = idSala;
                                    fx.IDCINE = idCine;
                                    fx.IDPELICULA = idPelicula;
                                }

                                var consultaE = db.Funcion_Entradas.Where(x => x.IDFUNCION.Equals(Id)).ToList();
                                foreach (Funcion_Entrada fe in consultaE)
                                {
                                    fe.HABILITADO = false;
                                }

                                int nLista = listaEntrada.Count();
                                for(int x=0; x<nLista; x++)
                                {
                                    var consultaD = db.Funcion_Entradas.Where(z => z.IDTIPOENTRADA.Equals(listaEntrada[x].idTipoEntrada) && (z.IDFUNCION.Equals(Id))).ToList();
                                    var consultaf = db.Funcion_Entradas.ToLookup(z => z.IDENTRADA).Count();
                                    int veces = consultaD.Count();
                                    if (veces  == 0) //si no existe se crea
                                    {
                                        Funcion_Entrada fe = new Funcion_Entrada
                                        {
                                            IDENTRADA = consultaf + 1,
                                            IDFUNCION = Id,
                                            IDTIPOENTRADA = listaEntrada[x].idTipoEntrada,
                                            PRECIO = listaEntrada[x].precio,
                                            HABILITADO = true
                                        };
                                        db.Funcion_Entradas.InsertOnSubmit(fe);
                                    }
                                    else //si existe se actualiza
                                    {
                                        foreach (Funcion_Entrada fex in consultaD)
                                        {
                                            fex.PRECIO = listaEntrada[x].precio;
                                            fex.HABILITADO = true;
                                        }
                                    }
                                }
                                db.SubmitChanges();
                                MessageBox.Show("Se editó correctamente");
                                transaccion.Complete();
                            }
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
                dgv_precios.DataSource = listaEntrada.ToList();
                dgv_precios.Columns[0].Visible = false;
                dgv_precios.Columns[1].HeaderText = "Tipo de entrada";
                dgv_precios.Columns[2].HeaderText = "Precio";
                for (int i = 0; i <= dgv_precios.Columns.Count - 1; i++)
                {
                    dgv_precios.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                return;
            }
            var consulta = listaEntrada.Where(x => x.idTipoEntrada.Equals(idTipoEntrada)).Count();
            if (consulta > 0)
            {
                MessageBox.Show("Ya se registro este tipo de entrada");
                dgv_precios.DataSource = listaEntrada.ToList();
                dgv_precios.Columns[0].Visible = false;
                dgv_precios.Columns[1].HeaderText = "Tipo de entrada";
                dgv_precios.Columns[2].HeaderText = "Precio";
                for (int i = 0; i <= dgv_precios.Columns.Count - 1; i++)
                {
                    dgv_precios.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                return;
            }
            else
            {
                listaEntrada.Add(new Entrada { idTipoEntrada = idTipoEntrada, nombreTipo = nombreTipo, precio = precio });
                for (int i = 0; i <= dgv_precios.Columns.Count - 1; i++)
                {
                    dgv_precios.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                dgv_precios.DataSource = listaEntrada.ToList();
                dgv_precios.Columns[0].Visible = false;
                dgv_precios.Columns[1].HeaderText = "Tipo de entrada";
                dgv_precios.Columns[2].HeaderText = "Precio";
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (!(dgv_precios.Rows.Count.Equals(0)))
            {
                if (MessageBox.Show("Seguro que desea eliminar el tipo de entrada?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgv_precios.CurrentRow.Cells[0].Value);
                    listaEntrada.RemoveAll(x=>x.idTipoEntrada.Equals(id));
                    dgv_precios.DataSource = null;
                    dgv_precios.DataSource = listaEntrada.ToList();
                    dgv_precios.Columns[0].Visible = false;
                    dgv_precios.Columns[1].HeaderText = "Tipo de entrada";
                    dgv_precios.Columns[2].HeaderText = "Precio";
                    for (int i = 0; i <= dgv_precios.Columns.Count - 1; i++)
                    {
                        dgv_precios.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    }
                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar pues no hay datos");
                dgv_precios.DataSource = listaEntrada.ToList();
                for (int i = 0; i <= dgv_precios.Columns.Count - 1; i++)
                {
                    dgv_precios.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                return;
            }
        }
    }
}
