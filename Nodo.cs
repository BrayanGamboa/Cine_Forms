using Cine_Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Nodo
    {
        public Pelicula pelicula { get; set; }
        public Nodo Siguiente { get; set; }
        public Nodo Anterior { get; set; }
        public static Nodo Primero { get; set; }
        public static Nodo Ultimo { get; set; }
    }
}
