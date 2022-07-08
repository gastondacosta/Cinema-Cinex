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
    public partial class frm_Mantenimiento_Sala : Form
    {
        public frm_Mantenimiento_Sala()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void Listar()
        {
            dgv_Cine.DataSource = (from salas in db.Salas
                                    join cine in db.Cines
                                    on salas.IDCINE equals cine.IDCINE
                                    where salas.HABILITADO.Equals(true) && cine.NOMBRE.Equals(comboBox1.Text)
                                    select new { Sala = salas.IDSALA, Cine = cine.NOMBRE, Butacas = salas.CANT_BUTACAS, Filas = salas.CANT_FILAS, Columnas = salas.CANT_COLUMNAS }).ToList();

            for (int i = 0; i <= dgv_Cine.Columns.Count - 1; i++)
            {
                dgv_Cine.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        private void frm_Mantenimiento_Sala_Load(object sender, EventArgs e)
        {
            Listar();
            comboBox1.DataSource = db.Cines;
            comboBox1.DisplayMember = "NOMBRE";
            comboBox1.ValueMember = "IDCINE";
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frm_PopUp_Sala salapop = new frm_PopUp_Sala();
            salapop.Titulo = "Agregar";
            salapop.Subtitulo = "Agregar sala";

            salapop.ShowDialog();

            if(salapop.DialogResult ==DialogResult.OK)
            {
                Listar();
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            frm_PopUp_Sala salapop = new frm_PopUp_Sala();
            salapop.Titulo = "Editar";
            salapop.Subtitulo = "Editar sala";
            salapop.IdSala = idSala;

            salapop.ShowDialog();

            if (salapop.DialogResult == DialogResult.OK)
            {
                Listar();
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea eliminar la sala?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                var consulta = db.Salas.Where(x => x.IDSALA.Equals(idSala)).ToList();
                foreach (Sala sala in consulta)
                {
                    sala.HABILITADO = false;
                }
                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("Se ha eliminado con éxito");
                    Listar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido eliminar");
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int idSala;
        private void dgv_Cines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSala = int.Parse(dgv_Cine.CurrentRow.Cells[0].Value.ToString());
        }

        private void txt_Cine_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_Cine.DataSource = (from salas in db.Salas
                                    join cine in db.Cines
                                    on salas.IDCINE equals cine.IDCINE
                                    where salas.HABILITADO.Equals(true) && cine.NOMBRE.Equals(comboBox1.Text)
                                    select new { Sala = salas.IDSALA, Cine = cine.NOMBRE, Butacas = salas.CANT_BUTACAS, Filas = salas.CANT_FILAS, Columnas = salas.CANT_COLUMNAS }).ToList();

            for (int i = 0; i <= dgv_Cine.Columns.Count - 1; i++)
            {
                dgv_Cine.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
