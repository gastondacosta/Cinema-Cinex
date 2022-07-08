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
    public partial class frm_Consulta_Pelicula : Form
    {
        public frm_Consulta_Pelicula()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void frm_Consulta_Pelicula_Load(object sender, EventArgs e)
        {
            cbo_GeneroPelicula.DataSource = db.Generos.Where(x => x.HABILITADO.Equals(true)).ToList();
            cbo_GeneroPelicula.DisplayMember = "NOMBRE_GENERO";
            cbo_GeneroPelicula.ValueMember = "IDGENERO";
            cbo_GeneroPelicula.SelectedIndex = -1;

            dgv_Pelicula.DataSource = (from peliculas in db.Peliculas
                                       join genero in db.Generos
                                       on peliculas.IDGENERO equals genero.IDGENERO
                                       join censura in db.Censuras
                                       on peliculas.IDTIPOCENSURA equals censura.IDCENSURA
                                       join pais in db.Pais
                                       on peliculas.IDPAIS equals pais.IDPAIS
                                       where peliculas.HABILITADO.Equals(true)
                                       select new { Titulo = peliculas.TITULO, Censura = censura.NOMBRECENSURA, Duracion = peliculas.DURACION, Estreno = peliculas.FECHA_ESTRENO, Pais = pais.PAIS }).ToList();

            for (int i = 0; i <= dgv_Pelicula.Columns.Count - 1; i++)
            {
                dgv_Pelicula.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (cbo_GeneroPelicula.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un genero");
                return;
            }

            dgv_Pelicula.DataSource = null;
            dgv_Pelicula.DataSource = (from peliculas in db.Peliculas
                                      join genero in db.Generos
                                      on peliculas.IDGENERO equals genero.IDGENERO
                                      join censura in db.Censuras
                                      on peliculas.IDTIPOCENSURA equals censura.IDCENSURA
                                      join pais in db.Pais
                                      on peliculas.IDPAIS equals pais.IDPAIS
                                      where peliculas.HABILITADO.Equals(true) && peliculas.IDGENERO.Equals(cbo_GeneroPelicula.SelectedValue)
                                      select new { Titulo = peliculas.TITULO, Censura = censura.NOMBRECENSURA, Duracion = peliculas.DURACION, Estreno = peliculas.FECHA_ESTRENO, Pais = pais.PAIS }).ToList();

            for (int i = 0; i <= dgv_Pelicula.Columns.Count - 1; i++)
            {
                dgv_Pelicula.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            cbo_GeneroPelicula.SelectedIndex = -1;
            dgv_Pelicula.DataSource = null;
            dgv_Pelicula.DataSource = (from peliculas in db.Peliculas
                                       join genero in db.Generos
                                       on peliculas.IDGENERO equals genero.IDGENERO
                                       join censura in db.Censuras
                                       on peliculas.IDTIPOCENSURA equals censura.IDCENSURA
                                       join pais in db.Pais
                                       on peliculas.IDPAIS equals pais.IDPAIS
                                       where peliculas.HABILITADO.Equals(true)
                                       select new { Titulo = peliculas.TITULO, Censura = censura.NOMBRECENSURA, Duracion = peliculas.DURACION, Estreno = peliculas.FECHA_ESTRENO, Pais = pais.PAIS }).ToList();

            for (int i = 0; i <= dgv_Pelicula.Columns.Count - 1; i++)
            {
                dgv_Pelicula.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
    }
}
