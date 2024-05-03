
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctharray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukkan panjang array : ");
            
            
            int a = int.Parse(Console.ReadLine());
            int[] array1 = new int[a];
            int max = array1[0];
            int r = 0;
            for (int i = 1; i <= a; i++)
            {
                Console.Write("a[{0}]= ", i);
                array1[i - 1] = int.Parse(Console.ReadLine());
                r = r + array1[i - 1];
                if (array1[i] % 2 != 0)
                {

                    Console.Write(array1[i]);
                }

            }
            Console.WriteLine("total={0}", r);
            Console.WriteLine( array1.Max());
            
            Console.ReadLine();
            
        }
    }
}
