using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prepraktikum1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3]
            {
                { 10, 20, 30 },
                { 40, 50, 60 },
                { 70, 80, 90}

            };
            int i, j;
            for(i = 0; i < 3; i++)
            {
                for(j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j]+" ");

                }   
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
