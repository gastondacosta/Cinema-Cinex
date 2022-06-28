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
    public partial class frm_PopUp_Sala : Form
    {
        public frm_PopUp_Sala()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public int IdSala { get; set; }
        private void frm_PopUp_Sala_Load(object sender, EventArgs e)
        {
            this.Text = Titulo;
            lbl_Subtitulo.Text = Subtitulo;

            cbo_Cine.DataSource = db.Cines.Where(x => x.HABILITADO.Equals(true)).ToList();
            cbo_Cine.ValueMember = "IDCINE";
            cbo_Cine.DisplayMember = "NOMBRE";

            if (Titulo=="Agregar")
            {
                cbo_Cine.SelectedIndex = -1;
                if (cbo_Cine.SelectedIndex.Equals(-1))
                {
                    txt_idsala.Text = "";
                }
            }

            if (Titulo == "Editar")
            {
                cbo_Cine.Enabled = false;
                txt_idsala.Text = IdSala.ToString();
                var consulta = db.Salas.Where(x=>x.IDSALA.Equals(IdSala)&&x.HABILITADO.Equals(true)).ToList();
                foreach (Sala sal in consulta)
                {
                    cbo_Cine.SelectedValue = sal.IDCINE;
                    nud_Butacas.Value = sal.CANT_BUTACAS;
                    nud_Columnas.Value = (int)sal.CANT_COLUMNAS;
                    nud_Filas.Value = sal.CANT_FILAS;
                }
            }
        }
        int numeracionx;
        string numeracion;
        private void cbo_Cine_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbo_Cine_SelectedValueChanged(object sender, EventArgs e)
        {
            numeracionx = (int)cbo_Cine.SelectedIndex + 1;
            numeracion = numeracionx.ToString() + "0";

            for(int x =1;x<20;)
            {
                numeracion += x.ToString();
                x++;
                var consulta = db.Salas.Where(y => y.IDSALA.Equals(numeracion)).Count();
                if (consulta > 0)
                {
                    numeracion = numeracion.Remove(2, 1);
                }
                else
                {
                    txt_idsala.Text = numeracion;
                    return;
                }
            }     
        }

        private void cbo_Cine_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (Titulo=="Agregar")
            {
                if (!String.IsNullOrWhiteSpace(txt_idsala.Text) && nud_Butacas.Value != 0 && (nud_Columnas.Value != 0) && (nud_Filas.Value != 0))
                {
                    if (MessageBox.Show("Seguro que desea agregar la sala?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        Sala sa = new Sala
                        {
                            IDSALA = int.Parse(txt_idsala.Text),
                            IDCINE = int.Parse(cbo_Cine.SelectedValue.ToString()),
                            CANT_BUTACAS = int.Parse(nud_Butacas.Text),
                            CANT_COLUMNAS = int.Parse(nud_Columnas.Text),
                            CANT_FILAS = int.Parse(nud_Filas.Text),
                            HABILITADO = true
                        };
                        db.Salas.InsertOnSubmit(sa);
                        try
                        {
                            db.SubmitChanges();
                            MessageBox.Show("Se ha agregado la sala correctamente");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se ha podido agregar");
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Complete los datos faltantes");
                    DialogResult = DialogResult.None;
                }

            }

            if (Titulo == "Editar")
            {
                if (nud_Butacas.Value != 0 && (nud_Columnas.Value != 0) && (nud_Filas.Value != 0))
                {
                    if (MessageBox.Show("Seguro que desea editar la sala?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        var consulta = db.Salas.Where(x => x.IDSALA.Equals(IdSala)).ToList();
                        foreach (Sala sl in consulta)
                        {
                            sl.CANT_BUTACAS = int.Parse(nud_Butacas.Value.ToString());
                            sl.CANT_FILAS = int.Parse(nud_Filas.Value.ToString());
                            sl.CANT_COLUMNAS = int.Parse(nud_Columnas.Value.ToString());
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
                    MessageBox.Show("Complete todos los campos");
                    DialogResult = DialogResult.None;
                }
            }
        }
    }
}
