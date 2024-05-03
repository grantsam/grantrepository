using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace arraypraktikum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a =
            {
                {1, 2, 3},
                {4, 5, 6},
                {5, 6, 7},
            };
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{a[i, j]}");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("")


            


            Console.ReadLine();
        }
    }
}
