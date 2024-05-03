using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum4_3_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digit nim terakhir = 2");
            Console.Write("jarak titik awal : ");
            int x=int.Parse(Console.ReadLine());
            Console.Write("banyak loncatan : ");
            int y=int.Parse(Console.ReadLine());
            int z = 2;// MY last NIM
            int a = 0;
            int b = 0;
            
            for (int i = 1; i <= y; i++)
            {
                b += z;
                a = x + b;
                Console.WriteLine("loncatan ke-" + i + " = " + a);
            }

            Console.ReadLine();
        }
    }
}
