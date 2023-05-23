using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace Cine_Forms
{
    public partial class Usuario : Form
    {

        

        public Usuario()
        {
            InitializeComponent();
        }

        private Nodo nodoActual = new Nodo();
        Cartelera cartelera = new Cartelera();

        private void Usuario_Load(object sender, EventArgs e)
        {
            cartelera.Nueva_Pelicula("Rayo McQueen 3", 120, "20:30", "Infantil", "https://images.squarespace-cdn.com/content/v1/51cdafc4e4b09eb676a64e68/1496440159826-TF8184WXHL586JE2MV8W/1.jpg?format=1500w");
            cartelera.Nueva_Pelicula("Mario Bros", 160, "20:30", "Infantil", "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/portals_3/2x1_SuperMarioHub_image1600w.jpg");
           
            nodoActual = cartelera.NodoInicial();
            GetPeliculaActual();
        }

        public void GetPeliculaActual()
        {
            if (nodoActual == null)
            {
                MessageBox.Show("No hay peliculas en cartelera", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Pelicula pelicula = nodoActual.pelicula;
                lbl_nombre.Text = pelicula.Nombre_pelicula;
                lbl_duracion.Text = pelicula.Duracion_pelicula.ToString();
                lbl_genero.Text = pelicula.Genero_pelicula;
                lbl_asientos.Text = pelicula.Asientos.ToString();
                SolicitarImagen(pelicula.Url_pelicula);
            }

        }

        private void img_Inicio_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void flecha_derecha_Click(object sender, EventArgs e)
        {
            if (nodoActual != null)
            {
                nodoActual = nodoActual.Siguiente;
                GetPeliculaActual();
            }
        }

        private void flecha_izquierda_Click(object sender, EventArgs e)
        {
            if (nodoActual != null)
            {
                nodoActual = nodoActual.Anterior;
                GetPeliculaActual();
            }
        }

        private void Reservar_Click(object sender, EventArgs e)
        {
            if (nodoActual.pelicula.Asientos < 1)
            {
                MessageBox.Show($"No hay asiento disponibles para: '{nodoActual.pelicula.Nombre_pelicula}'", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                nodoActual.pelicula.Asientos--;
                lbl_asientos.Text = nodoActual.pelicula.Asientos.ToString();
                MessageBox.Show("¡Asiento reservado con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public async void SolicitarImagen(string url)
        {
            try
            {
                HttpClient client = new HttpClient();
                byte[] imageBytes = await client.GetByteArrayAsync(url);
                Console.WriteLine("jkab");
                using (MemoryStream memoryStream = new MemoryStream(imageBytes))
                {
                    Image image = Image.FromStream(memoryStream);
                    img_pelicula.Image = image;
                }
            }
            catch (Exception err)
            {
                img_pelicula.Image = (Image)Properties.Resources.ResourceManager.GetObject("errot");
                MessageBox.Show($"Error al cargar la imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
