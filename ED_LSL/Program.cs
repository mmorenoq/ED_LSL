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

            if (lista.EstaVacia())
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                Console.WriteLine("La lista tiene datos");
            }

            lista.VaciarLista();

            if (lista.EstaVacia())
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                Console.WriteLine("La lista tiene datos");
            }

            Console.ReadKey();
            
        }
    }
}
