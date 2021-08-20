using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2008
{
    public class CollectionsExample
    {
        public static void SortedListCollection()
        {
            //consultar cantidad de elementos a agregar
            Console.Write("Cuantos elementos agregara: ");
            var elements = Convert.ToInt32(Console.ReadLine());

            //declaracion del SortedList()
            SortedList<object, object> srtList = new SortedList<object, object>();
            int i = 0;

            while (i < elements)
            {
                Console.WriteLine("Escriba el elemento agregar {0}", i);
                Console.Write("Key: ");
                var key = Console.ReadLine();
                Console.Write("Value: ");
                var value = Console.ReadLine();

                //llenar SortedList()
                srtList.Add(key, value);

                i++; //incremento del valor de i
            }

            //imprimir los elementos almacenados en SortedList()
            Console.WriteLine("ELEMENTOS EN SORTEDLIST");
            foreach (KeyValuePair<object, object> element in srtList)
            {
                Console.WriteLine("{0} => {1}", element.Key, element.Value);
            }
        }

        public static void ListCollection()
        {
            //declaracion de una lista
            List<object> lst = new List<object>();

            //capturar los elementos para almacenar dentro de la lista
            var rs = "s";
            while (rs == "s")
            {
                Console.Write("Escriba el elemento a agregar en la lista: ");
                var element = Console.ReadLine(); //capturar el valor mediante teclado

                //agregar el elemento a la lista
                lst.Add(element);

                //preguntar al usuario si desea agregar otro elemento
                Console.Write("\nDesea agregar otro elemento? s/n ");
                rs = Console.ReadLine();
            }

            //leer la lista y mostrar los elementos almacenados
            Console.WriteLine("\n------------Elementos en la lista---------------");
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine("Elemento {0}: {1}", i, lst[i]);
            }
        }
    }
}
