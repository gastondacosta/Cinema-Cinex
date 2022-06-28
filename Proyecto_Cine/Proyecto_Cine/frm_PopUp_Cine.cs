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
    public partial class frm_PopUp_Cine : Form
    {
        public frm_PopUp_Cine()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public string Id { get; set; }
        private void frm_PopUp_Cine_Load(object sender, EventArgs e)
        {
            this.Text = Titulo;
            this.lbl_Subtitulo.Text = Subtitulo;
            cbo_TipoCine.DataSource = db.Tipo_Cines.ToList();
            cbo_TipoCine.DisplayMember = "NOMBRE";
            cbo_TipoCine.ValueMember = "IDTIPOCINE";
            cbo_TipoCine.SelectedIndex = -1;

            if (Titulo == "Agregar")
            {
                var consulta = db.Cines.ToLookup(x => x.IDCINE).Count();
                txt_ID.Text = (consulta + 1).ToString();
            }
            if (Titulo == "Editar")
            {
                txt_ID.Text = Id;
                var consulta = db.Cines.Where(x => x.IDCINE.Equals(Id)).ToList();
                foreach (Cine cin in consulta)
                {
                    txt_Nombre.Text = cin.NOMBRE;
                    txt_Direccion.Text = cin.DIRECCION;
                    txt_Contacto.Text = cin.CONTACTO;
                    txt_fechadeApertura.Text = cin.FECHA_APERTURA;
                    cbo_TipoCine.SelectedValue = cin.IDTIPOCINE;
                }
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (this.Text == "Agregar")
            {
                if (!String.IsNullOrWhiteSpace(txt_Nombre.Text) && cbo_TipoCine.SelectedIndex != -1)
                {
                    if (MessageBox.Show("Seguro que desea agregar este elemento?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        Cine ci = new Cine
                        {
                            IDCINE = int.Parse(txt_ID.Text),
                            NOMBRE = txt_Nombre.Text,
                            DIRECCION = txt_Direccion.Text,
                            CONTACTO = txt_Contacto.Text,
                            FECHA_APERTURA = txt_fechadeApertura.Text,
                            IDTIPOCINE = int.Parse(cbo_TipoCine.SelectedValue.ToString()),
                            HABILITADO = true
                        };
                        db.Cines.InsertOnSubmit(ci);
                        try
                        {
                            db.SubmitChanges();
                            MessageBox.Show("Agregado con éxito");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ha ocurrido un error");
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

            if (this.Text == "Editar")
            {
                if (!String.IsNullOrWhiteSpace(txt_Nombre.Text) && cbo_TipoCine.SelectedIndex != -1)
                {

                    if (MessageBox.Show("Seguro que desea editar este elemento?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        var consulta = db.Cines.Where(x => x.IDCINE.Equals(txt_ID.Text)).ToList();
                        foreach (Cine ci in consulta)
                        {
                            ci.FECHA_APERTURA = txt_fechadeApertura.Text;
                            ci.DIRECCION = txt_Direccion.Text;
                            ci.CONTACTO = txt_Contacto.Text;
                            ci.NOMBRE = txt_Nombre.Text;
                            ci.IDTIPOCINE = int.Parse(cbo_TipoCine.SelectedValue.ToString());
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
        }
    }
}
