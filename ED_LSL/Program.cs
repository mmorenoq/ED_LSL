using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_LSL
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            lista.AgregarNodo("Uno");
            lista.AgregarNodo("Dos");
            lista.AgregarNodo("Tres");
            lista.AgregarNodo("Cuatro");
            lista.AgregarNodo("Cinco");

            Console.WriteLine(lista.RecorrerLista());
            Console.WriteLine("<==Agregando nodo al inicio de la lista==>\n");
            lista.AgregarNodoInicio("Cero");
            Console.WriteLine(lista.RecorrerLista());

            Console.WriteLine("\n<==Busqueda de nodo en la lista==>\n");
            Nodo nodo = lista.Buscar("Cuatro");
            if (nodo == null)
            {
                Console.WriteLine("Dato no encontrado");
            }
            else
            {
                Console.WriteLine($"Se encontro el nodo con valor {nodo.Dato}");
            }

            Console.WriteLine("\n<==Eliminando nodo de la lista==>\n");
            lista.BorrarNodo("Cuatro");
            Console.WriteLine(lista.RecorrerLista());

            Console.WriteLine("\n<==Busqueda por indice en la lista==>\n");
            Nodo nodoIndice = lista.BuscarIndice(3);
            int Indice = 3;
            if (nodoIndice == null)
            {
                Console.WriteLine("Indice no encontrado");
            }
            else
            {
                Console.WriteLine($"Se encontro el indice {Indice} con valor {nodoIndice.Dato}");
            }

            //if (lista.EstaVacia())
            //{
            //    Console.WriteLine("La lista esta vacia");
            //}
            //else
            //{
            //    Console.WriteLine("La lista tiene datos");
            //}

            //lista.VaciarLista();

            //if (lista.EstaVacia())
            //{
            //    Console.WriteLine("La lista esta vacia");
            //}
            //else
            //{
            //    Console.WriteLine("La lista tiene datos");
            //}

            Console.ReadKey();
            
        }
    }
}
