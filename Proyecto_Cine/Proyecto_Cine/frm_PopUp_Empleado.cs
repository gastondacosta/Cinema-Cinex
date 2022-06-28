using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Cine
{
    public partial class frm_PopUp_Empleado : Form
    {
        public frm_PopUp_Empleado()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public int Id { get; set; }
        private void frm_PopUp_Empleado_Load(object sender, EventArgs e)
        {
            this.Text = Titulo;
            lbl_Subtitulo.Text = Subtitulo;

            cbo_Modalidad.DataSource = db.Tipo_Modalidads;
            cbo_Modalidad.DisplayMember = "NOMBRE";
            cbo_Modalidad.ValueMember = "IDTIPO_MODALIDAD";

            cbo_tipoEmpleado.DataSource = db.Tipo_Empleados;
            cbo_tipoEmpleado.DisplayMember = "NOMBRE";
            cbo_tipoEmpleado.ValueMember = "IDTIPO_EMPLEADO";

            if (Titulo == "Agregar")
            {
                var consulta = db.Empleados.ToLookup(x => x.IDEMPLEADO).Count();
                txt_ID.Text = (consulta + 1).ToString();
                cbo_tipoEmpleado.SelectedIndex = -1;
                cbo_Modalidad.SelectedIndex = -1;
            }

            if (Titulo == "Editar")
            {
                txt_ID.Text = Id.ToString();
                var consulta = db.Empleados.Where(x => x.IDEMPLEADO.Equals(Id)).ToList();
                foreach (Empleado emp in consulta)
                {
                    txt_Nombre.Text = emp.NOMBRE_EMPLEADO;
                    txt_Apellido.Text = emp.APELLIDO;
                    txt_Sueldo.Text = emp.SUELDO.ToString();
                    txt_fechadeInicio.Text = emp.FECHA_INICIO;
                    txt_Usuario.Text = emp.USUARIO;
                    txt_Contraseña.Text = emp.CONTRASEÑA;
                    cbo_Modalidad.SelectedValue = emp.IDTIPO_MODALIDAD;
                    cbo_tipoEmpleado.SelectedValue = emp.IDTIPO_EMPLEADO;
                }
            }

            if (Titulo == "Datos")
            {
                txt_Apellido.ReadOnly = true;
                txt_Contraseña.ReadOnly = true;
                txt_fechadeInicio.Enabled = false;
                txt_Nombre.ReadOnly = true;
                txt_Sueldo.ReadOnly = true;
                txt_Usuario.ReadOnly = true;
                cbo_Modalidad.Enabled = false;
                cbo_tipoEmpleado.Enabled = false;
                txt_Contraseña.UseSystemPasswordChar = false;

                txt_ID.Text = Id.ToString();
                var consulta = db.Empleados.Where(x => x.IDEMPLEADO.Equals(Id)).ToList();
                foreach (Empleado emp in consulta)
                {
                    txt_Nombre.Text = emp.NOMBRE_EMPLEADO;
                    txt_Apellido.Text = emp.APELLIDO;
                    txt_Sueldo.Text = emp.SUELDO.ToString();
                    txt_fechadeInicio.Text = emp.FECHA_INICIO;
                    txt_Usuario.Text = emp.USUARIO;
                    txt_Contraseña.Text = emp.CONTRASEÑA;
                    cbo_Modalidad.SelectedValue = emp.IDTIPO_MODALIDAD;
                    cbo_tipoEmpleado.SelectedValue = emp.IDTIPO_EMPLEADO;
                }
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (Titulo == "Editar")
            {
                if (!String.IsNullOrWhiteSpace(txt_Nombre.Text) && !String.IsNullOrWhiteSpace(txt_Apellido.Text) && !String.IsNullOrWhiteSpace(txt_Contraseña.Text) && !String.IsNullOrWhiteSpace(txt_Usuario.Text) && !String.IsNullOrWhiteSpace(txt_Sueldo.Text))
                {
                    if (MessageBox.Show("Seguro que desea realizar los cambios?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        var consulta1 = db.Empleados.Where(x => x.IDEMPLEADO.Equals(Id)).ToList();
                        foreach (Empleado empl in consulta1)
                        {
                            empl.NOMBRE_EMPLEADO = txt_Nombre.Text;
                            empl.APELLIDO = txt_Apellido.Text;
                            empl.SUELDO = Convert.ToDecimal(txt_Sueldo.Text);
                            empl.FECHA_INICIO = txt_fechadeInicio.Text;
                            empl.USUARIO = txt_Usuario.Text;
                            empl.CONTRASEÑA = txt_Contraseña.Text;
                            empl.IDTIPO_MODALIDAD = (int)cbo_Modalidad.SelectedValue;
                            empl.IDTIPO_EMPLEADO = (int)cbo_tipoEmpleado.SelectedValue;
                        }
                        try
                        {
                            db.SubmitChanges();
                            MessageBox.Show("Se ha editado con éxito");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se ha podido editar");
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Complete todos los datos");
                    DialogResult = DialogResult.None;
                }
            }
            if (Titulo == "Agregar")
            {
                if (!String.IsNullOrWhiteSpace(txt_Nombre.Text) && !String.IsNullOrWhiteSpace(txt_Apellido.Text) && !String.IsNullOrWhiteSpace(txt_Contraseña.Text) && !String.IsNullOrWhiteSpace(txt_Usuario.Text) && !String.IsNullOrWhiteSpace(txt_Sueldo.Text) && !(cbo_Modalidad.SelectedIndex < 0) && !(cbo_tipoEmpleado.SelectedIndex < 0))
                {
                    if (MessageBox.Show("Seguro que desea agregar el empleado?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        Empleado emple = new Empleado()
                        {
                            IDEMPLEADO = Convert.ToInt32(txt_ID.Text),
                            NOMBRE_EMPLEADO = txt_Nombre.Text,
                            APELLIDO = txt_Apellido.Text,
                            SUELDO = Convert.ToDecimal(txt_Sueldo.Text),
                            FECHA_INICIO = txt_fechadeInicio.Text,
                            USUARIO = txt_Usuario.Text,
                            CONTRASEÑA = txt_Contraseña.Text,
                            IDTIPO_MODALIDAD = (int)cbo_Modalidad.SelectedValue,
                            IDTIPO_EMPLEADO = (int)cbo_tipoEmpleado.SelectedValue,
                            HABILITADO = true,
                            BLOQUEADO = false
                        };
                        db.Empleados.InsertOnSubmit(emple);
                        try
                        {
                            db.SubmitChanges();
                            MessageBox.Show("Se ha agregado con éxito");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se ha podido agregar");
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Complete todos los datos");
                    DialogResult = DialogResult.None;
                }
            }
        }
    }
}
