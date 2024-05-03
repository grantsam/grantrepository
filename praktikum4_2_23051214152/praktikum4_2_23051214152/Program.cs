using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum4_2_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukkan banyak nilai yang ingin dimasukkan : ");
            int x = int.Parse(Console.ReadLine());
            double a = 0;
            for (int i=1;i <=x;i++)
            {
                Console.Write("nilai ke-" + i + " = ");
                double y= double.Parse(Console.ReadLine());
                
                a += y;

            }
            double b = 0;
            b = a / x;
            Console.WriteLine("total nilai = "+a);
            Console.WriteLine("rata rata nilai =" + b);
            Console.ReadLine();
        }
    }
}
