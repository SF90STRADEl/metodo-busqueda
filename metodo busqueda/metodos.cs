using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos_de_busqueda
{
    internal class metodos
    {
        public void print(int[] array)
        {
            foreach (int k in array)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
        }

        public void Binary(int[] array, int x)
        {


            int left, cen, right;
            bool ban;
            int n = array.Length - 1;

            left = 0;
            right = n;
            ban = false;
            cen = 0;

            while ((left <= right) && (ban == false))
            {
                cen = (left + right) / 2;

                if (array[cen] == x)
                {
                    ban = true;
                }
                else
                {
                    if (x > array[cen])
                    {
                        left = cen + 1;
                    }
                    else
                    {
                        right = cen - 1;
                    }
                }

            }
            print(array);
            if (ban == true)
            {
                Console.WriteLine("The information is in the position: " + cen);
            }
            else
            {
                Console.WriteLine("The information is not in the array");
            }
        }

        public void Secuential_unordered(int[] v, int x)
        {
            int i = 0;
            int n = v.Length - 1;

            while ((i <= n) && (v[i] != x))
            {
                i++;
            }
            if (i > n)
            {
                Console.WriteLine("The information is not in the array");
            }
            else
            {
                print(v);
                Console.WriteLine("The information is in the position: " + i);
            }
        }
    }
}
