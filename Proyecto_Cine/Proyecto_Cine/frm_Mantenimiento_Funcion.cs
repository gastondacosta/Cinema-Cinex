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
    public partial class frm_Mantenimiento_Funcion : Form
    {
        public frm_Mantenimiento_Funcion()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void Listar()
        {
            dgv_Funciones.DataSource = (from funcion in db.Funcions
                                       join peli in db.Peliculas
                                       on funcion.IDPELICULA equals peli.IDPELICULA
                                       join cine in db.Cines
                                       on funcion.IDCINE equals cine.IDCINE
                                       join sala in db.Salas
                                       on funcion.IDSALA equals sala.IDSALA
                                       where funcion.HABILITADO.Equals(true)
                                       select new { funcion.IDFUNCION, Pelicula = peli.TITULO, Fecha = funcion.FECHAFUNCION, Horario = funcion.HORARIO, Cine = cine.NOMBRE, Sala= sala.IDSALA }).ToList();

            cbo_Pelicula.DataSource = db.Peliculas.Where(x => x.HABILITADO.Equals(true));
            cbo_Pelicula.DisplayMember = "TITULO";
            cbo_Pelicula.ValueMember = "IDPELICULA";
        }

        private void frm_Mantenimiento_Funcion_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frm_PopUp_Funcion popF = new frm_PopUp_Funcion();
            popF.Titulo = "Agregar";
            popF.Subtitulo = "Agregar Función";

            popF.ShowDialog();
            if (popF.DialogResult == DialogResult.OK)
            {
                Listar();
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            frm_PopUp_Funcion popF = new frm_PopUp_Funcion();
            popF.Titulo = "Editar";
            popF.Subtitulo = "Editar Función";
            popF.Id = idFuncion;

            popF.ShowDialog();
            if(popF.DialogResult == DialogResult.OK)
            {
                Listar();
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea eliminar la función?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                var consulta = db.Funcions.Where(x => x.IDFUNCION.Equals(idFuncion)).ToList();
                foreach (Funcion func in consulta)
                {
                    func.HABILITADO = false;
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
        int idFuncion;
        private void dgv_Funciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idFuncion = int.Parse(dgv_Funciones.CurrentRow.Cells[0].Value.ToString());
        }

        private void cbo_Pelicula_SelectionChangeCommitted(object sender, EventArgs e)
        {
                dgv_Funciones.DataSource = (from funcion in db.Funcions
                                            join peli in db.Peliculas
                                            on funcion.IDPELICULA equals peli.IDPELICULA
                                            join cine in db.Cines
                                            on funcion.IDCINE equals cine.IDCINE
                                            join sala in db.Salas
                                            on funcion.IDSALA equals sala.IDSALA
                                            where funcion.HABILITADO.Equals(true) && funcion.IDPELICULA.Equals(cbo_Pelicula.SelectedValue)
                                            select new { funcion.IDFUNCION, Pelicula = peli.TITULO, Fecha = funcion.FECHAFUNCION, Horario = funcion.HORARIO, Cine = cine.NOMBRE, Sala = sala.IDSALA }).ToList();
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
