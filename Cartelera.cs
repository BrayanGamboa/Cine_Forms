using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Forms
{
    internal class Cartelera
    {
        private Pelicula Primero = new Pelicula();
        private Pelicula Ultimo = new Pelicula();

        public Cartelera() {
            Primero = null;
            Ultimo = null;
        }

        public void Nueva_Pelicula(string nombre, int duracion, string horario, string genero, string url_img, int id)
        {
            Pelicula Nuevo = new Pelicula();

            Nuevo.Nombre_pelicula = nombre;
            Nuevo.Duracion_pelicula = duracion;
            Nuevo.Horario_pelicula = horario;
            Nuevo.Genero_pelicula = genero;
            Nuevo.Url_pelicula = url_img;
            Nuevo.Id_pelicula = id;

            if (Primero == null)
            {
                Primero = Nuevo;
                Primero.Apuntador = null;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Apuntador = Nuevo;
                Nuevo.Apuntador = null;
                Ultimo = Nuevo;
            }
        }

        public Pelicula Mostrar_Lista()
        {
            Pelicula Actual = new Pelicula();
            Actual = Primero;
            
            if (Primero != null)
            {
                while (Actual != null)
                {
                    Actual = Actual.Apuntador;
                    
                }
                return Actual;
            }
            else
            {
                return null;
            }
        }



        public Pelicula Buscar_Pelicula(int dato_buscar)
        {
            Pelicula Actual = new Pelicula();
            Actual = Primero;
            bool localizar_nodo = false;

            while (Actual != null && localizar_nodo == false)
            {
                //if (Actual.Dato == dato_buscar)
                //{
                //    return Actual.Apuntador;
                //}
                Actual = Actual.Apuntador;
            }
            return null;
        }

        //public int Tomar_Id_Anterior()
        //{

        //}


    }
}
