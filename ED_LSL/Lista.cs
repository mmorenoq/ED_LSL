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
        public void AgregarNodoInicio(string Dato)
        {
            Nodo NodoNuevo = new Nodo();
            NodoNuevo.Dato = Dato;
            NodoNuevo.Siguiente = primerNodo.Siguiente;
            primerNodo.Siguiente = NodoNuevo;
        }
        public Nodo Buscar(string Dato)
        {
            if (EstaVacia())
	        {
                return null;
	        }

            Nodo NodoBusqueda = new Nodo();
            NodoBusqueda = primerNodo;

            while (NodoBusqueda.Siguiente != null)
            {
                NodoBusqueda = NodoBusqueda.Siguiente;
                if (NodoBusqueda.Dato == Dato)
                {
                    return NodoBusqueda;
                }
            }

            return null;
        }
        public Nodo BuscarAnterior(string Dato)
        {
            if (EstaVacia())
            {
                return null;
            }

            Nodo NodoBusqueda = new Nodo();
            NodoBusqueda = primerNodo;

            while (NodoBusqueda.Siguiente != null && NodoBusqueda.Siguiente.Dato != Dato)
            {
                NodoBusqueda = NodoBusqueda.Siguiente;
                if (NodoBusqueda.Siguiente.Dato == Dato)
                {
                    return NodoBusqueda;
                }
            }
            return null;
        }
        public void BorrarNodo(string Dato)
        {
            if (!EstaVacia())
            {
                nodoActual = Buscar(Dato);

                if (nodoActual == null)
                {
                    return;
                }

                Nodo nodoAnterior = BuscarAnterior(Dato);
                nodoAnterior.Siguiente = nodoActual.Siguiente;
                nodoActual.Siguiente = null;
            }
        }
        public Nodo BuscarIndice(int Indice)
        {
            int indice = -1;

            if (EstaVacia())
            {
                return null;
            }

            nodoActual = primerNodo;

            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                indice++;

                if (indice == Indice)
                {
                    return nodoActual;
                }
            }
            return null;
        }
    }
}
