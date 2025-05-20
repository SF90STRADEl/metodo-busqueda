using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos_de_busqueda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            metodos metodos = new metodos();


            int opt;

            int[] array = new int[] { 1, 4, 6, 8, 10, 13, 16, 30, 136, 346, 578, 9735 };

            hash hash = new hash(array.Length);

            while (true)
            {
                Console.WriteLine("\nArreglo:");
                metodos.print(array);

                Console.WriteLine("\n=== Menú de Búsqueda y Hashtable ===");
                Console.WriteLine("1. Búsqueda Secuencial");
                Console.WriteLine("2. Búsqueda Binaria");
                Console.WriteLine("3. Agregar Arreglo A Hashtable");
                Console.WriteLine("4. Mostrar Hashtable");
                Console.WriteLine("5. Buscar en Hashtable");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");
                opt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();



                switch (opt)
                {
                    case 1:
                        Console.Write("Inserte el valor a buscar: ");
                        int valSeq = Convert.ToInt32(Console.ReadLine());
                        metodos.Secuential_unordered(array, valSeq);
                        break;

                    case 2:
                        Console.Write("Inserte el valor a buscar: ");
                        int valBin = Convert.ToInt32(Console.ReadLine());
                        metodos.Binary(array, valBin);
                        break;

                    case 3:
                        int clave = 0;
                        foreach (var valor in array)
                        {
                            hash.Insert(clave, valor);
                            clave++;
                        }
                        break;

                    case 4:
                        hash.DisplayTable();
                        break;

                    case 5:
                        Console.Write("Inserte la clave a buscar: ");
                        int keySearch = Convert.ToInt32(Console.ReadLine());
                        hash.Get(keySearch);
                        break;
                    case 6:
                        Console.WriteLine("Gracias por usar el programa");
                        return;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;

                }
            }
        }
    }
}
