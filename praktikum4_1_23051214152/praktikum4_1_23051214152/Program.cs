using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum4_1_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("volume kolam : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("penambahan air setiap berapa menit : ");
            int y= int.Parse(Console.ReadLine());
            Console.Write("liter debit air per menit : ");
            int z = int.Parse(Console.ReadLine());

            double a = 0;
            double b = 0;
            double c = 0;
            
            for (int i = 1;a<x;i++)
            {
                
                a += z;
                b += y;
                c = (b * x) / a;
                if (a >= x)
                {

                    a = x;
                    Console.WriteLine("menit ke-" + c + " = " + a);
                }
                else if (a < x)
                {
                    Console.WriteLine("menit ke-" + b + " = " + a);
                }


            }

            Console.ReadLine();
        }
    }
}
