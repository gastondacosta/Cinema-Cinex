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
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Mantenimiento_Cliente cliente = new frm_Mantenimiento_Cliente();
            cliente.ShowDialog();
        }

        private void cinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Mantenimiento_Cine cine = new frm_Mantenimiento_Cine();
            cine.ShowDialog();
        }

        private void películaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Mantenimiento_Pelicula peli = new frm_Mantenimiento_Pelicula();
            peli.ShowDialog();
        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Mantenimiento_Sala sala = new frm_Mantenimiento_Sala();
            sala.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Mantenimiento_Empleado emp = new frm_Mantenimiento_Empleado();
            emp.ShowDialog();
        }

        private void funciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Mantenimiento_Funcion fun = new frm_Mantenimiento_Funcion();
            fun.ShowDialog();
        }
    }
}
