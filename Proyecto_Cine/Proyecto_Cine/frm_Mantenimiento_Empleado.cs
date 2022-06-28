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
    public partial class frm_Mantenimiento_Empleado : Form
    {
        public frm_Mantenimiento_Empleado()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        int id;
        private void Listar()
        {
            dgv_Empleados.DataSource = (from empleado in db.Empleados
                                        join tipoE in db.Tipo_Empleados
                                        on empleado.IDTIPO_EMPLEADO equals tipoE.IDTIPO_EMPLEADO
                                        join tipoM in db.Tipo_Modalidads
                                        on empleado.IDTIPO_MODALIDAD equals tipoM.IDTIPO_MODALIDAD
                                        where empleado.HABILITADO.Equals(true)
                                        select new { empleado.IDEMPLEADO, empleado.NOMBRE_EMPLEADO, empleado.APELLIDO, Cargo = tipoE.NOMBRE, Contrato = tipoM.NOMBRE, empleado.SUELDO, empleado.FECHA_INICIO }).ToList();
        }
        private void frm_Mantenimiento_Empleado_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frm_PopUp_Empleado popE = new frm_PopUp_Empleado();
            popE.Titulo = "Agregar";
            popE.Subtitulo = "Agregar Empleado";

            popE.ShowDialog();

            if(popE.DialogResult == DialogResult.OK)
            {
                Listar();
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            frm_PopUp_Empleado popE = new frm_PopUp_Empleado();
            popE.Titulo = "Editar";
            popE.Subtitulo = "Editar Empleado";
            popE.Id = id;
            popE.txt_Contraseña.Visible = false;
            popE.lbl_Contra.Visible = false;

            popE.ShowDialog();

            if (popE.DialogResult == DialogResult.OK)
            {
                Listar();
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea eliminar el empleado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                var consulta = db.Empleados.Where(x => x.IDEMPLEADO.Equals(id)).ToList();
                foreach (Empleado emp in consulta)
                {
                    emp.HABILITADO = false;
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

        private void dgv_Empleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgv_Empleados.CurrentRow.Cells[0].Value.ToString());
        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            dgv_Empleados.DataSource = (from empleado in db.Empleados
                                        join tipoE in db.Tipo_Empleados
                                        on empleado.IDTIPO_EMPLEADO equals tipoE.IDTIPO_EMPLEADO
                                        join tipoM in db.Tipo_Modalidads
                                        on empleado.IDTIPO_MODALIDAD equals tipoM.IDTIPO_MODALIDAD
                                        where empleado.HABILITADO.Equals(true) && empleado.NOMBRE_EMPLEADO.Contains(txt_Nombre.Text)
                                        select new { empleado.IDEMPLEADO, empleado.NOMBRE_EMPLEADO, empleado.APELLIDO, Cargo = tipoE.NOMBRE, Modalidad = tipoM.NOMBRE, empleado.SUELDO, empleado.FECHA_INICIO }).ToList();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            frm_PopUp_Empleado popE = new frm_PopUp_Empleado();
            popE.Titulo = "Datos";
            popE.Subtitulo = "Datos empleado";
            popE.Id = id;

            popE.ShowDialog();
        }
    }
}
