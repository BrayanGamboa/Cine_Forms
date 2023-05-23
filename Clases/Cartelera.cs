using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3;

namespace Cine_Forms
{
    internal class Cartelera
    {
        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();

        public Cartelera() {
            Primero = null;
            Ultimo = null;
        }

        public void Nueva_Pelicula(string nombre, int duracion, string horario, string genero, string url_img)
        {
            Nodo Nuevo = new Nodo();
            Pelicula pelicula = new Pelicula();

            pelicula.Nombre_pelicula = nombre;
            pelicula.Duracion_pelicula = duracion;
            pelicula.Horario_pelicula = horario;
            pelicula.Genero_pelicula = genero;
            pelicula.Url_pelicula = url_img;
            pelicula.Asientos = 30;

            Nuevo.pelicula = pelicula;

            if (Nodo.Primero == null)
            {
                Nodo.Primero = Nuevo;                
                Nodo.Ultimo = Nuevo;
            }
            else
            {
                Nuevo.Siguiente = Nodo.Primero;
                Nodo.Primero.Anterior = Nuevo;
                Nuevo.Anterior = Nodo.Ultimo;
                Nodo.Ultimo.Siguiente = Nuevo;
                Nodo.Ultimo = Nuevo;
            }
        }

        public Nodo NodoInicial()
        {
            return Nodo.Primero;
        }









    }
}
