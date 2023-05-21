using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine_Forms
{
    public partial class Admin : Form
    {
        Cartelera cartelera = new Cartelera();
        public Admin()
        {
            InitializeComponent();
        }

        void Limpiar_Datos()
        {
            nombre_Pelicula.Clear();
            duracion_Pelicula.Clear();
            horario_Pelicula.Clear();
            genero_Pelicula.SelectedIndex = 0;
            url_Imagen.Clear();
        }


        private void enviar_Datos_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = nombre_Pelicula.Text;
                int duracion = int.Parse(duracion_Pelicula.Text);
                string horario = horario_Pelicula.Text;
                string genero = genero_Pelicula.Text;
                string url = url_Imagen.Text;

                if (nombre == "" || duracion == 0 || horario == "" || genero == "" || url == "")
                    MessageBox.Show("Faltan datos por ingresar");
                else
                {
                    
                    cartelera.Nueva_Pelicula(nombre, duracion, horario, genero, url, 1);
                    Limpiar_Datos();
                }


            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message);
            }


        }

        private void inicio_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }
    }
}
