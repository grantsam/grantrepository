using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikumS2_1_1_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input panjang array = ");
            int a = int.Parse(Console.ReadLine());
            int[]b = new int[a];
            int total = 0;
            for (int i = 1; i <= a; i++)
            {
                Console.Write("array[{0}] = ", i);
                b[i - 1] = int.Parse(Console.ReadLine());
                total = total + b[i - 1];

            }
            Console.WriteLine("total nilai array adalah {0}", total);
            Console.ReadLine();
        }
    }
}
