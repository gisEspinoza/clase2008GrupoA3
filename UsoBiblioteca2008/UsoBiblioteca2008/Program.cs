using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca2008;

namespace UsoBiblioteca2008
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione el elemento a crear: ");
            Console.WriteLine("1. List");
            Console.WriteLine("2. SortedList");
            var response = Console.ReadLine();

            //evaluar respuesta del usuario
            if (response == "1")
            {
                CollectionsExample.ListCollection();
            }
            else if(response=="2")
            {
                CollectionsExample.SortedListCollection();
            }

            Console.ReadKey();
        }
    }
}
