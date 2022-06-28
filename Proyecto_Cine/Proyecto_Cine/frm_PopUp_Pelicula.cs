using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Cine
{
    public partial class frm_PopUp_Pelicula : Form
    {
        public frm_PopUp_Pelicula()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public string Id { get; set; }
        private void frm_PopUp_Pelicula_Load(object sender, EventArgs e)
        {
            this.Text = Titulo;
            lbl_Subtitulo.Text = Subtitulo;

            cbo_Genero.DataSource = db.Generos.Where(x => x.HABILITADO.Equals(true)).ToList();
            cbo_Genero.DisplayMember = "NOMBRE_GENERO";
            cbo_Genero.ValueMember = "IDGENERO";

            cbo_pais.DataSource = db.Pais.Where(x => x.HABILITADO.Equals(true)).ToList();
            cbo_pais.DisplayMember = "PAIS";
            cbo_pais.ValueMember = "IDPAIS";

            cbo_Censura.DataSource = db.Censuras.Where(x => x.HABILITADO.Equals(true)).ToList();
            cbo_Censura.DisplayMember = "NOMBRECENSURA";
            cbo_Censura.ValueMember = "IDCENSURA";

            if (Titulo == "Agregar")
            {
                var ids = db.Peliculas.ToLookup(x => x.IDPELICULA).Count();
                txt_ID.Text = (ids + 1).ToString();
                cbo_Censura.SelectedIndex = -1;
                cbo_Genero.SelectedIndex = -1;
                cbo_pais.SelectedIndex = -1;
                label3.Text += "(*)";
                label5.Text += "(*)";
                label7.Text += "(*)";
            }

            if (Titulo == "Editar")
            {
                txt_ID.Text = Id;
                var peli = db.Peliculas.Where(x => x.IDPELICULA.Equals(Id)).ToList();
                foreach (Pelicula pe in peli)
                {
                    txt_Nombre.Text = pe.TITULO;
                    txt_fechadeEstreno.Value = Convert.ToDateTime(pe.FECHA_ESTRENO);
                    txt_Sinopsis.Text = pe.SINOPSIS;
                    txt_Duracion.Text = pe.DURACION;
                    cbo_Censura.SelectedValue = pe.IDTIPOCENSURA ;
                    cbo_pais.SelectedValue = pe.IDPAIS ;
                    cbo_Genero.SelectedValue = pe.IDGENERO ;
                }
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (Titulo == "Editar")
            {
                if (!String.IsNullOrWhiteSpace(txt_Nombre.Text) && !String.IsNullOrWhiteSpace(txt_Duracion.Text))
                {
                    if (MessageBox.Show("Seguro que desea realizar los cambios?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        var peli = db.Peliculas.Where(x => x.IDPELICULA.Equals(Id)).ToList();
                        foreach (Pelicula pe in peli)
                        {
                            pe.TITULO = txt_Nombre.Text;
                            pe.FECHA_ESTRENO = txt_fechadeEstreno.Text;
                            pe.SINOPSIS = txt_Sinopsis.Text;
                            pe.DURACION = txt_Duracion.Text;
                            pe.IDTIPOCENSURA = int.Parse(cbo_Censura.SelectedValue.ToString());
                            pe.IDPAIS = int.Parse(cbo_pais.SelectedValue.ToString());
                            pe.IDGENERO = int.Parse(cbo_Genero.SelectedValue.ToString());
                        }
                        try
                        {
                            db.SubmitChanges();
                            MessageBox.Show("Se ha editado con éxito");
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
                    MessageBox.Show("Complete los campos obligatorios");
                    DialogResult = DialogResult.None;
                }
            }

            if (Titulo == "Agregar")
            {
                if (!String.IsNullOrWhiteSpace(txt_Nombre.Text) && !String.IsNullOrWhiteSpace(txt_Duracion.Text))
                {
                    if (MessageBox.Show("Seguro que desea agregar la película?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        Pelicula pel = new Pelicula
                        {
                            IDPELICULA = int.Parse(txt_ID.Text),
                            IDGENERO = int.Parse(cbo_Genero.SelectedValue.ToString()),
                            IDPAIS = int.Parse(cbo_pais.SelectedValue.ToString()),
                            IDTIPOCENSURA = int.Parse(cbo_Censura.SelectedValue.ToString()),
                            TITULO = txt_Nombre.Text,
                            FECHA_ESTRENO = txt_fechadeEstreno.Text,
                            SINOPSIS = txt_Sinopsis.Text,
                            DURACION = txt_Duracion.Text,
                            HABILITADO = true
                        };
                        db.Peliculas.InsertOnSubmit(pel);
                        try
                        {
                            db.SubmitChanges();
                            MessageBox.Show("Se ha agregado con éxito");
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("No se ha podido agregar la película");
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Complete los campos obligatorios");
                    DialogResult=DialogResult.None;
                }
            }
        }
    }
}
