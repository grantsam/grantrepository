
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace TugasPraktikum3_4_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Program Menampilkan Bilangan Ganjil antara 1-20 metode While");
            
            while (i <20)
            {
                i++;
                if (i % 2 != 0)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            int x = 0;
            Console.WriteLine("Program Menampilkan Bilangan Ganjil antara 1-20 metode D0-While");
            do
            {
                x++;
                if (x % 2 != 0)
                {

                    Console.Write(x);
                    Console.Write(" ");
                }
            }
            while (x < 20);
         



            Console.ReadLine();
        }
    }
}
