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
    public partial class frm_Consulta_Cliente : Form
    {
        public frm_Consulta_Cliente()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void frm_Consulta_Cliente_Load(object sender, EventArgs e)
        {
            dgv_Cliente.DataSource = (from reserva in db.Reservas
                                       join empleado in db.Empleados
                                       on reserva.IDEMPLEADO equals empleado.IDEMPLEADO
                                       join cliente in db.Clientes
                                       on reserva.IDCLIENTE equals cliente.IDCLIENTE
                                       where reserva.HABILITADO.Equals(true)// && reserva.IDCLIENTE.Equals(cliente.DNI)
                                       select new { reserva.IDRESERVA, DNI = cliente.DNI, Cliente = cliente.NOMBRE + " " + cliente.APELLIDO, Empleado = empleado.NOMBRE_EMPLEADO + " " + empleado.APELLIDO, Total = reserva.TOTAL }).ToList();

            dgv_Cliente.Columns[0].HeaderText = "ID Reserva";

            for (int i = 0; i <= dgv_Cliente.Columns.Count - 1; i++)
            {
                dgv_Cliente.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void txt_Cliente_TextChanged(object sender, EventArgs e)
        {
            dgv_Cliente.DataSource = (from reserva in db.Reservas
                                      join empleado in db.Empleados
                                      on reserva.IDEMPLEADO equals empleado.IDEMPLEADO
                                      join cliente in db.Clientes
                                      on reserva.IDCLIENTE equals cliente.IDCLIENTE
                                      where reserva.HABILITADO.Equals(true) && cliente.DNI.Contains(txt_Cliente.Text)
                                      select new { reserva.IDRESERVA, DNI = cliente.DNI, Cliente = cliente.NOMBRE + " " + cliente.APELLIDO, Empleado = empleado.NOMBRE_EMPLEADO + " " + empleado.APELLIDO, Total = reserva.TOTAL }).ToList();


            dgv_Cliente.Columns[0].HeaderText = "ID Reserva";
            for (int i = 0; i <= dgv_Cliente.Columns.Count - 1; i++)
            {
                dgv_Cliente.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            txt_Cliente.Text = "";
            dgv_Cliente.DataSource = null;
            dgv_Cliente.DataSource = (from reserva in db.Reservas
                                      join empleado in db.Empleados
                                      on reserva.IDEMPLEADO equals empleado.IDEMPLEADO
                                      join cliente in db.Clientes
                                      on reserva.IDCLIENTE equals cliente.IDCLIENTE
                                      where reserva.HABILITADO.Equals(true)
                                      select new { reserva.IDRESERVA, DNI = cliente.DNI, Cliente = cliente.NOMBRE + " " + cliente.APELLIDO, Empleado = empleado.NOMBRE_EMPLEADO + " " + empleado.APELLIDO, Total = reserva.TOTAL }).ToList();

            dgv_Cliente.Columns[0].HeaderText = "ID Reserva";
            for (int i = 0; i <= dgv_Cliente.Columns.Count - 1; i++)
            {
                dgv_Cliente.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void dgv_Cliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idReserva = Convert.ToInt32(dgv_Cliente.CurrentRow.Cells[0].Value);
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
                            select new { Cliente = cliente.NOMBRE + " " + cliente.APELLIDO, Cine = cine.NOMBRE, Sala = sala.IDSALA, Pelicula = pelicula.TITULO, Horario = funcion.HORARIO, Precio = detalleR.PRECIO }).ToList();
            dgv_Detalle.DataSource = consulta;

            for (int i = 0; i <= dgv_Detalle.Columns.Count - 1; i++)
            {
                dgv_Detalle.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
