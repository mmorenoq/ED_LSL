using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_LSL
{
    public class Lista
    {
        private Nodo primerNodo;
        private Nodo nodoActual;

        public Lista()
        {
            primerNodo = new Nodo();
            primerNodo.Siguiente = null;
        }
        public string RecorrerLista()
        {
            string datosNodos = string.Empty;

            nodoActual = primerNodo;

            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                datosNodos += $"{nodoActual.Dato}\n";
            }
            return datosNodos;
        }
        public void VaciarLista()
        {
            primerNodo.Siguiente = null;
        }
        public bool EstaVacia()
        {
            if (primerNodo.Siguiente == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AgregarNodo(string Dato)
        {
            nodoActual = primerNodo;

            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }

            Nodo nodoNuevo = new Nodo();
            nodoNuevo.Dato = Dato;
            nodoNuevo.Siguiente = null;
            nodoActual.Siguiente = nodoNuevo;
        }
    }
}
