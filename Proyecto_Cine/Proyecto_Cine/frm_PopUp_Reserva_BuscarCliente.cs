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
    public partial class frm_PopUp_Reserva_BuscarCliente : Form
    {
        public frm_PopUp_Reserva_BuscarCliente()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        public string IdC { get; set; }
        public string NombreCompleto { get; set; }
        private void Listar()
        {
            dgv_Cliente.DataSource = db.Clientes.Where(x => x.Habilitado.Equals(true)).Select(x => new { ID = x.IDCLIENTE, x.DNI, Nombre =  x.NOMBRE, Apellido = x.APELLIDO, Nacimiento = x.FECHADENACIMIENTO, Correo = x.CORREO }).ToList();

            for (int i = 0; i <= dgv_Cliente.Columns.Count - 1; i++)
            {
                dgv_Cliente.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        private void frm_PopUp_Reserva_BuscarCliente_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void txt_DniBuscar_TextChanged(object sender, EventArgs e)
        {
            dgv_Cliente.DataSource = db.Clientes.Where(x => x.Habilitado.Equals(true) && x.DNI.Contains(txt_DniBuscar.Text)).Select(x => new { ID = x.IDCLIENTE, x.DNI, Nombre = x.NOMBRE, Apellido = x.APELLIDO, Nacimiento = x.FECHADENACIMIENTO, Correo = x.CORREO }).ToList();

            for (int i = 0; i <= dgv_Cliente.Columns.Count - 1; i++)
            {
                dgv_Cliente.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea agregar al cliente?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (!String.IsNullOrEmpty(txt_Dni.Text) || !String.IsNullOrEmpty(txt_Nombre.Text) || !String.IsNullOrEmpty(txt_Apellido.Text) || !String.IsNullOrEmpty(txt_fechaDeN.Text))
                {
                    var consulta = db.Clientes.Where(x => x.DNI.Equals(txt_Dni.Text)).Select(x => x).ToList();
                    if (!consulta.Any())
                    {
                        var consulta0 = db.Clientes.ToLookup(x => x.IDCLIENTE).Count();
                        Cliente cli = new Cliente
                        {
                            IDCLIENTE = consulta0 + 1,
                            NOMBRE = txt_Nombre.Text,
                            APELLIDO = txt_Apellido.Text,
                            FECHADENACIMIENTO = txt_fechaDeN.Text,
                            CORREO = txt_email.Text,
                            DNI = txt_Dni.Text,
                            Habilitado = true
                        };
                        db.Clientes.InsertOnSubmit(cli);
                        try
                        {
                            db.SubmitChanges();
                            Listar();
                            MessageBox.Show("Se ha agregado el cliente y fue listado en la grilla");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se ha podido agregar al cliente");
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un cliente con este DNI");
                        DialogResult = DialogResult.None;
                    }
                }
                else
                {
                    MessageBox.Show("Complete todos los campos obligatorios");
                    DialogResult= DialogResult.None;
                }
            }
            
        }
        int idCliente;
        string nombreCompletoC;
        private void dgv_Cliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente = Convert.ToInt32(dgv_Cliente.CurrentRow.Cells[0].Value);
            nombreCompletoC = dgv_Cliente.CurrentRow.Cells[2].Value.ToString() + " " + dgv_Cliente.CurrentRow.Cells[3].Value.ToString();
            IdC = idCliente.ToString();
            NombreCompleto = nombreCompletoC;
            DialogResult = DialogResult.OK;
        }
    }
}
