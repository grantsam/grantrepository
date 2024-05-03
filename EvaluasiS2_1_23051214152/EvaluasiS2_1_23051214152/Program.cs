using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluasiS2_1_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("banyak array = ");
            int a =int.Parse(Console.ReadLine());
            int[] x = new int[a];
            int b = 0;
            int total = 0;
            int data = 0;
           

            for(int i = 0; i < a; i++)
            {
                Console.Write("nilai array [{0}] = ", i);
                b = int.Parse(Console.ReadLine());
                x[i] = b;

                if(x[i] % 2 != 0 && x[i] % 5 == 0)
                {
                    total += b;
                    data++;
                }
                
            }
            for (int i = 0; i < a; i++)
            {
                if (data > 0)
                {
                    if (x[i] % 2 != 0 && x[i] % 5 == 0)
                    {

                        Console.Write(x[i] + " ");
                    }
                    
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("jumlah data ganjil habis dibagi 5 = {0} ", total);
            int rata = total / data;
            Console.WriteLine("rata rata data ganjil hais dibagi 5 = {0}", rata);
            Console.ReadLine();
        }
    }
}
