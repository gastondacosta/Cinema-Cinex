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
    public partial class frm_Mantenimiento_Pelicula : Form
    {
        public frm_Mantenimiento_Pelicula()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void Listar()
        {
            dgv_Peliculas.DataSource = (from pelicula in db.Peliculas
                                        join generos in db.Generos
                                        on pelicula.IDGENERO equals generos.IDGENERO
                                        join pais in db.Pais
                                        on pelicula.IDPAIS equals pais.IDPAIS
                                        join censura in db.Censuras
                                        on pelicula.IDTIPOCENSURA equals censura.IDCENSURA
                                        where pelicula.HABILITADO.Equals(true)
                                        select new { ID = pelicula.IDPELICULA, Título = pelicula.TITULO, Género = generos.NOMBRE_GENERO, Censura = censura.NOMBRECENSURA, Duración = pelicula.DURACION, Pais = pais.PAIS, Sinopsis = pelicula.SINOPSIS }).ToList();

            dgv_Peliculas.Columns[0].HeaderText = "ID Pelicula";

            for (int i = 0; i <= dgv_Peliculas.Columns.Count - 1; i++)
            {
                dgv_Peliculas.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        private void frm_Mantenimiento_Pelicula_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void txt_Pelicula_TextChanged(object sender, EventArgs e)
        {
            dgv_Peliculas.DataSource = (from pelicula in db.Peliculas
                                        join generos in db.Generos
                                        on pelicula.IDGENERO equals generos.IDGENERO
                                        join pais in db.Pais
                                        on pelicula.IDPAIS equals pais.IDPAIS
                                        join censura in db.Censuras
                                        on pelicula.IDTIPOCENSURA equals censura.IDCENSURA
                                        where pelicula.HABILITADO.Equals(true) && pelicula.TITULO.Contains(txt_Pelicula.Text)
                                        select new { ID = pelicula.IDPELICULA, Título = pelicula.TITULO, Género = generos.NOMBRE_GENERO, Censura = censura.NOMBRECENSURA, Duración = pelicula.DURACION, Pais = pais.PAIS, Sinopsis = pelicula.SINOPSIS }).ToList();

            dgv_Peliculas.Columns[0].HeaderText = "ID Pelicula";
            for (int i = 0; i <= dgv_Peliculas.Columns.Count - 1; i++)
            {
                dgv_Peliculas.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frm_PopUp_Pelicula poP = new frm_PopUp_Pelicula();
            poP.Titulo = "Agregar";
            poP.Subtitulo = "Agregar Pelicula";

            poP.ShowDialog();

            if (poP.DialogResult == DialogResult.OK)
            {
                Listar();
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            frm_PopUp_Pelicula poP = new frm_PopUp_Pelicula();
            poP.Titulo = "Editar";
            poP.Subtitulo = "Editar Pelicula";
            poP.Id = id;

            poP.ShowDialog();

            if (poP.DialogResult == DialogResult.OK)
            {
                Listar();
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea eliminar el cliente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                var consulta = db.Peliculas.Where(x => x.TITULO.Equals(id)).ToList();
                foreach (Pelicula peli in consulta)
                {
                    peli.HABILITADO = false;
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
        public string id;
        private void dgv_Peliculas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgv_Peliculas.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgv_Peliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
