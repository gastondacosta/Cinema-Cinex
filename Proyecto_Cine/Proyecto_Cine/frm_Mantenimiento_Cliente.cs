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
    public partial class frm_Mantenimiento_Cliente : Form
    {
        public frm_Mantenimiento_Cliente()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void Listar()
        {
            txt_Dni.Text = "";
            dgv_Cliente.DataSource = (from cliente in db.Clientes
                                     where cliente.Habilitado.Equals(1)
                                     select new 
                                     {
                                         Nombre = cliente.NOMBRE,
                                         Apellido = cliente.APELLIDO,
                                         DNI = cliente.DNI,
                                         Fecha = cliente.FECHADENACIMIENTO,
                                         Correo = cliente.CORREO
                                     }).ToList();

            for (int i = 0; i <= dgv_Cliente.Columns.Count - 1; i++)
            {
                dgv_Cliente.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        private void tsl_Editar_Click(object sender, EventArgs e)
        {
            frm_popUp_Mantenimiento_Cliente popUp = new frm_popUp_Mantenimiento_Cliente();
            popUp.Titulo = "Editar";
            popUp.Subtitulo = "Editar cliente";
            popUp.Dni = dni;

            popUp.ShowDialog();
            if (popUp.DialogResult == DialogResult.OK)
            {
                Listar();
            }
        }

        private void tsl_Nuevo_Click(object sender, EventArgs e)
        {
            frm_popUp_Mantenimiento_Cliente popUp = new frm_popUp_Mantenimiento_Cliente();
            popUp.Titulo = "Agregar";
            popUp.Subtitulo = "Ingresar cliente";

            popUp.ShowDialog();
            if (popUp.DialogResult == DialogResult.OK)
            {
                Listar();
            }
        }

        private void frm_Mantenimiento_Cliente_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void txt_Dni_TextChanged(object sender, EventArgs e)
        {
            dgv_Cliente.DataSource = (from cliente in db.Clientes
                                      where cliente.Habilitado.Equals(1) && cliente.DNI.Contains(txt_Dni.Text)
                                      select new
                                      {
                                          Nombre = cliente.NOMBRE,
                                          Apellido = cliente.APELLIDO,
                                          DNI = cliente.DNI,
                                          Fecha = cliente.FECHADENACIMIENTO,
                                          Correo = cliente.CORREO
                                      }).ToList();

            for (int i = 0; i <= dgv_Cliente.Columns.Count - 1; i++)
            {
                dgv_Cliente.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        private void tsl_Eliminar_Click(object sender, EventArgs e)
        {
            var consulta = db.Clientes.Where(x => x.DNI.Equals(dni));
            if (MessageBox.Show("Seguro que desea eliminar el cliente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                foreach (var cons in consulta)
                {
                    cons.Habilitado = false;
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

        private void txt_Dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        string dni, nombre, apellido, nacimiento, correo;
        private void dgv_Cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nombre = dgv_Cliente.CurrentRow.Cells[0].Value.ToString();
            apellido = dgv_Cliente.CurrentRow.Cells[1].Value.ToString();
            dni = dgv_Cliente.CurrentRow.Cells[2].Value.ToString();
            nacimiento = dgv_Cliente.CurrentRow.Cells[3].Value.ToString();
            correo = dgv_Cliente.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
