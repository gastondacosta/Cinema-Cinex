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
    public partial class frm_Consulta_Empleado : Form
    {
        public frm_Consulta_Empleado()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void frm_Consulta_Empleado_Load(object sender, EventArgs e)
        {
            cbo_Empleado.DataSource = db.Empleados.Where(x => x.HABILITADO.Equals(true)).Select(x=>new {IDEMPLEADO = x.IDEMPLEADO, NYAP = x.NOMBRE_EMPLEADO + " " + x.APELLIDO}).ToList();
            cbo_Empleado.DisplayMember = "NYAP";
            cbo_Empleado.ValueMember = "IDEMPLEADO";
            cbo_Empleado.SelectedIndex = -1;

            dgv_Empleado.DataSource = (from reserva in db.Reservas
                                       join empleado in db.Empleados
                                       on reserva.IDEMPLEADO equals empleado.IDEMPLEADO
                                       join cliente in db.Clientes
                                       on reserva.IDCLIENTE equals cliente.IDCLIENTE
                                       where reserva.HABILITADO.Equals(true)
                                       select new { reserva.IDRESERVA, Cliente = cliente.NOMBRE + " " + cliente.APELLIDO, Empleado = empleado.NOMBRE_EMPLEADO + " " + empleado.APELLIDO, Total = reserva.TOTAL }).ToList();

            dgv_Empleado.Columns[0].HeaderText = "ID Reserva";
            for (int i = 0; i <= dgv_Empleado.Columns.Count - 1; i++)
            {
                dgv_Empleado.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if(cbo_Empleado.SelectedIndex == -1)
            {
                MessageBox.Show("Elija un empleado para buscar");
                return;
            }
            dgv_Empleado.DataSource = null;
            dgv_Empleado.DataSource = (from reserva in db.Reservas
                                       join empleado in db.Empleados
                                       on reserva.IDEMPLEADO equals empleado.IDEMPLEADO
                                       join cliente in db.Clientes
                                       on reserva.IDCLIENTE equals cliente.IDCLIENTE
                                       where reserva.HABILITADO.Equals(true) && reserva.IDEMPLEADO.Equals(cbo_Empleado.SelectedValue)
                                       select new { reserva.IDRESERVA, Cliente = cliente.NOMBRE + " " + cliente.APELLIDO, Empleado = empleado.NOMBRE_EMPLEADO + " " + empleado.APELLIDO, Total = reserva.TOTAL }).ToList();

            dgv_Empleado.Columns[0].HeaderText = "ID Reserva";
            for (int i = 0; i <= dgv_Empleado.Columns.Count - 1; i++)
            {
                dgv_Empleado.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            cbo_Empleado.SelectedIndex = -1;
            dgv_Empleado.DataSource = null;
            dgv_Empleado.DataSource = (from reserva in db.Reservas
                                       join empleado in db.Empleados
                                       on reserva.IDEMPLEADO equals empleado.IDEMPLEADO
                                       join cliente in db.Clientes
                                       on reserva.IDCLIENTE equals cliente.IDCLIENTE
                                       where reserva.HABILITADO.Equals(true)
                                       select new { reserva.IDRESERVA, Cliente = cliente.NOMBRE + " " + cliente.APELLIDO, Empleado = empleado.NOMBRE_EMPLEADO + " " + empleado.APELLIDO, Total = reserva.TOTAL }).ToList();
            dgv_Detalle.DataSource = null;

            dgv_Empleado.Columns[0].HeaderText = "ID Reserva";
            for (int i = 0; i <= dgv_Empleado.Columns.Count - 1; i++)
            {
                dgv_Empleado.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void dgv_Empleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idReserva = Convert.ToInt32(dgv_Empleado.CurrentRow.Cells[0].Value);
            var consulta = (from detalleR in db.Detalle_Reservas
                           join cliente in db.Clientes
                           on detalleR.IDCLIENTE equals cliente.IDCLIENTE
                           join funcion in db.Funcions
                           on detalleR.IDFUNCION equals funcion.IDFUNCION
                           join pelicula in db.Peliculas
                           on funcion.IDPELICULA equals pelicula.IDPELICULA
                           join cine in db.Cines
                           on funcion.IDCINE equals cine.IDCINE
                           join sala in db.Salas
                           on funcion.IDSALA equals sala.IDSALA
                           where detalleR.HABILTIADO.Equals(true) && detalleR.IDRESERVA.Equals(idReserva)
                           select new {Cliente = cliente.NOMBRE + " " + cliente.APELLIDO, Cine = cine.NOMBRE, Sala = sala.IDSALA, Pelicula = pelicula.TITULO,Horario = funcion.HORARIO, Precio = detalleR.PRECIO}).ToList();
            dgv_Detalle.DataSource = consulta;

            for (int i = 0; i <= dgv_Detalle.Columns.Count - 1; i++)
            {
                dgv_Detalle.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
