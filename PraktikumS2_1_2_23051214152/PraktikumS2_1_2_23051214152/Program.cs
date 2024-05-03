using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PraktikumS2_1_2_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input panjang array = ");
            int a = int.Parse(Console.ReadLine());
            int[] b = new int[a];

            for (int i = 1; i <= a; i++)
            {
                Console.Write("array [{0}] = ");
                b[i - 1] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("nilai maksimum pada array adalah " + b.Max() );
            Console.WriteLine("nilai minimum pada array adalah  " + b.Min() );
            Console.ReadLine();
        }
    }
}
