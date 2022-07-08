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
    public partial class frm_PopUp_Reserva_BuscarEmpleado : Form
    {
        public frm_PopUp_Reserva_BuscarEmpleado()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        public string Id { get; set; }
        public string NombreCompleto { get; set; }
        private void frm_PopUp_Reserva_BuscarEmpleado_Load(object sender, EventArgs e)
        {
            dgv_Empleados.DataSource = db.Empleados.Where(x => x.HABILITADO.Equals(true)).Select(x => new { ID = x.IDEMPLEADO, Nombre = x.NOMBRE_EMPLEADO, Apellido = x.APELLIDO }).ToList();

            for (int i = 0; i <= dgv_Empleados.Columns.Count - 1; i++)
            {
                dgv_Empleados.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void txt_ApellidoEmpleado_TextChanged(object sender, EventArgs e)
        {
            dgv_Empleados.DataSource = db.Empleados.Where(x => x.HABILITADO.Equals(true) && x.APELLIDO.Contains(txt_ApellidoEmpleado.Text)).Select(x => new { ID = x.IDEMPLEADO, Nombre = x.NOMBRE_EMPLEADO, Apellido = x.APELLIDO }).ToList();

            for (int i = 0; i <= dgv_Empleados.Columns.Count - 1; i++)
            {
                dgv_Empleados.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        string idEmpleado;
        string nombreCompletoE;
        private void dgv_Empleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idEmpleado = dgv_Empleados.CurrentRow.Cells[0].Value.ToString();
            nombreCompletoE = dgv_Empleados.CurrentRow.Cells[1].Value.ToString() + " " + dgv_Empleados.CurrentRow.Cells[2].Value.ToString();
            Id = idEmpleado;
            NombreCompleto = nombreCompletoE;
            DialogResult = DialogResult.OK;
        }
    }
}
