using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace kendali_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            
            Console.Write("masukkan nilai bawah : ");
            x = int.Parse(Console.ReadLine());
            Console.Write("masukkan nilai atas : ");
            y = int.Parse(Console.ReadLine());

            for (int i =x; x<=y; x++)
            {
                if (x %2 == 0)
                {
                    Console.Write(x + " = genap");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(x + " = ganjil");
                    Console.WriteLine();
                }
                
            }
            Console.ReadLine();
        }
    }
}
