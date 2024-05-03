using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum1_4_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double phi = 3.14;
            double v;
            double r;
            Console.WriteLine("masukkan jari-jari : ");
            r = double.Parse(Console.ReadLine());
            v = 1.33 * phi * r * r;
            Console.WriteLine("luas lingkaran adalah :{0}", v);
            Console.ReadLine();

        }
    }
}
