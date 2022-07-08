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
    public partial class frm_Mantenimiento_Cine : Form
    {
        public frm_Mantenimiento_Cine()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void Listar()
        {
            dgv_Cines.DataSource = (from cines in db.Cines
                                   join tcines in db.Tipo_Cines
                                   on cines.IDTIPOCINE equals tcines.IDTIPOCINE
                                   where cines.HABILITADO.Equals(true)
                                   select new { cines.IDCINE, Cine = cines.NOMBRE, tcines.NOMBRE, Dirección = cines.DIRECCION, Contacto = cines.CONTACTO }).ToList();

            dgv_Cines.Columns[0].HeaderText = "ID Cine";
            dgv_Cines.Columns[2].HeaderText = "Tipo";
            for (int i = 0; i <= dgv_Cines.Columns.Count - 1; i++)
            {
                dgv_Cines.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frm_PopUp_Cine frmMC = new frm_PopUp_Cine();
            frmMC.Titulo = "Agregar";
            frmMC.Subtitulo = "Agregar Cine";

            frmMC.ShowDialog();
            if (frmMC.DialogResult == DialogResult.OK)
            {
                Listar();
            }
        }

        private void txt_Cine_TextChanged(object sender, EventArgs e)
        {
            dgv_Cines.DataSource = (from cines in db.Cines
                                    join tcines in db.Tipo_Cines
                                    on cines.IDTIPOCINE equals tcines.IDTIPOCINE
                                    where cines.HABILITADO.Equals(true) && cines.NOMBRE.Contains(txt_Cine.Text)
                                    select new { cines.IDCINE, Cine = cines.NOMBRE, tcines.NOMBRE, Dirección = cines.DIRECCION, Contacto = cines.CONTACTO }).ToList();

            dgv_Cines.Columns[0].HeaderText = "ID Cine";
            dgv_Cines.Columns[2].HeaderText = "Tipo";
            for (int i = 0; i <= dgv_Cines.Columns.Count - 1; i++)
            {
                dgv_Cines.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void frm_Mantenimiento_Cine_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void tsl_Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea eliminar el cine?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string id = dgv_Cines.CurrentRow.Cells[0].Value.ToString();
                var consultaE = db.Cines.Where(x => x.IDCINE.Equals(id)).ToList();
                foreach (Cine cine in consultaE)
                {
                    cine.HABILITADO = false;
                }
                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("Eliminado con éxito");
                    Listar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido eliminar");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tsl_Editar_Click(object sender, EventArgs e)
        {
            frm_PopUp_Cine frmMC = new frm_PopUp_Cine();
            frmMC.Titulo = "Editar";
            frmMC.Subtitulo = "Editar Cine";
            frmMC.Id = dgv_Cines.CurrentRow.Cells[0].Value.ToString();

            frmMC.ShowDialog();
            if (frmMC.DialogResult == DialogResult.OK)
            {
                Listar();
            }
        }
    }
}
