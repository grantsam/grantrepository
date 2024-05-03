using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikumS2_1_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukkan panjang array : ");
            int a = int.Parse(Console.ReadLine());

            int[] x = new int[a];
            int[] y = new int[a];
            int[] z = new int[a];
            Console.WriteLine("Array 1");
            for (int i = 0; i < a; i++)
            {
                Console.Write("panjang array [{0}] = ", i);
                int b = int.Parse(Console.ReadLine());
                x[i] = b;
            }
            Console.WriteLine();
            Console.WriteLine("Array 2");
            for (int i = 0; i < a; i++)
            {
                Console.Write("panjang array [{0}] = ", i);
                int b = int.Parse(Console.ReadLine());
                y[i] = b;
            }
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                Console.Write(x[i] + " ");
                
             
            }
            Console.WriteLine();
            
            for (int i = 0; i < a; i++)
            {
                Console.Write(y[i] + " ");
                
            }
            Console.WriteLine();
            
            for (int i = 0; i < a; i++)
            {
                z[i] = x[i]+y[i];
            }
            for (int i = 0; i < a; i++)
            {
                Console.Write(z[i] + " ");
                
            }
            Console.ReadLine();
        }
    }
}
