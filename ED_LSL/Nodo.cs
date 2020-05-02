using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_LSL
{
    public class Nodo
    {
        private string dato;
        private Nodo siguiente;

        public string Dato { get => dato; set => dato = value; }
        public Nodo Siguiente { get => siguiente; set => siguiente = value; }

        public Nodo()
        {
            siguiente = null;
        }
    }
}
