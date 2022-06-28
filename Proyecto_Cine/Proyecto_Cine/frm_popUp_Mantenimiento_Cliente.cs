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
    public partial class frm_popUp_Mantenimiento_Cliente : Form
    {
        public frm_popUp_Mantenimiento_Cliente()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public string Dni { get; set; }
        private void frm_popUp_Mantenimiento_Cliente_Load(object sender, EventArgs e)
        {
            this.Text = Titulo;
            lbl_Subtitulo.Text = Subtitulo;

            if (this.Text == "Editar")
            {
                txt_DNI.Text = Dni;
                var consulta = (db.Clientes.Where(x => x.DNI.Equals(Dni))).ToList();
                foreach (var cons in consulta)
                {
                    txt_Nombre.Text = cons.NOMBRE;
                    txt_Apellido.Text = cons.APELLIDO;
                    txt_fechadeNacimiento.Text = cons.FECHADENACIMIENTO;
                    txt_email.Text = cons.CORREO;
                }
            }

        }

        private void btn_Aceptar_Click_1(object sender, EventArgs e)
        {
            if (this.Text == "Agregar")
            {
                if (!String.IsNullOrEmpty(txt_DNI.Text)|| !String.IsNullOrEmpty(txt_Nombre.Text) || !String.IsNullOrEmpty(txt_Apellido.Text))
                {
                    var consulta12 = (from client in db.Clientes
                                      where client.DNI.Equals(txt_DNI.Text)
                                      select client).ToList();
                    if (!consulta12.Any())
                    {
                        var consulta0 = db.Clientes.ToLookup(x => x.IDCLIENTE).Count();
                        Cliente cli = new Cliente
                        {
                            IDCLIENTE = consulta0 + 1,
                            DNI = txt_DNI.Text,
                            NOMBRE = txt_Nombre.Text,
                            APELLIDO = txt_Apellido.Text,
                            FECHADENACIMIENTO = txt_fechadeNacimiento.Text,
                            CORREO = txt_email.Text,
                            Habilitado = true
                        };
                        db.Clientes.InsertOnSubmit(cli);
                        try
                        {
                            db.SubmitChanges();
                            MessageBox.Show("Se ha agregado un nuevo cliente con éxito");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ha ocurrido un error");
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya está ingresado un cliente con ese DNI");
                        DialogResult = DialogResult.None;
                    }
                }
                else
                {
                    MessageBox.Show("Complete todos los campos obligatorios");
                    DialogResult = DialogResult.None;
                }
            }

            if (this.Text == "Editar")
            {
                if (MessageBox.Show("Seguro que desea realizar los cambios?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    var consulta = db.Clientes.Where(x => x.DNI.Equals(Dni)).ToList();
                    foreach (Cliente cons in consulta)
                    {
                        cons.DNI = txt_DNI.Text;
                        cons.NOMBRE = txt_Nombre.Text;
                        cons.APELLIDO = txt_Apellido.Text;
                        cons.FECHADENACIMIENTO = txt_fechadeNacimiento.Text;
                        cons.CORREO = txt_email.Text;
                    }
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error");
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
