using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Forms
{
    internal class Pelicula
    {
        private string nombre_pelicula;
        private int duracion_pelicula;
        private string horario_pelicula;
        private string url_pelicula;
        private string genero_pelicula;
        private int id_pelicula;
        private Pelicula apuntador;

        public string Nombre_pelicula { get => nombre_pelicula; set => nombre_pelicula = value; }
        public int Duracion_pelicula { get => duracion_pelicula; set => duracion_pelicula = value; }
        public string Horario_pelicula { get => horario_pelicula; set => horario_pelicula = value; }
        public string Url_pelicula { get => url_pelicula; set => url_pelicula = value; }
        public string Genero_pelicula { get => genero_pelicula; set => genero_pelicula = value; }
        public int Id_pelicula { get => id_pelicula; set => id_pelicula = value; }
        internal Pelicula Apuntador { get => apuntador; set => apuntador = value; }
    }
}
