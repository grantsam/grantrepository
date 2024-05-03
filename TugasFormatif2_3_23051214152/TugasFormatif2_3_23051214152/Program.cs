using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasFormatif2_3_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alas, tinggi, luas;
            Console.Write("masukkan alas : ");
            alas = int.Parse(Console.ReadLine());
            Console.Write("masukkan tinggi : ");
            tinggi = int.Parse(Console.ReadLine());
            luas = (alas * tinggi) / 2;
            Console.WriteLine("luas = (alas * tinggi) / 2 ");
            Console.WriteLine("luas = ({0} * {1}) /2 ", alas, tinggi);
            int alastinggi = alas * tinggi;
            Console.WriteLine("luas = ({0}) / 2 ", alastinggi);
            Console.WriteLine("luas = {0} cm ", luas);

            //disarankan untuk menggunakan angka istimewa
            double keliling, miring;
            double alas2 = alas * alas;
            double tinggi2 = tinggi * tinggi;
            miring = Math.Sqrt(alas2 + tinggi2);
            keliling = alas + tinggi + miring;
            Console.WriteLine("keliling = alas + tinggi + miring ");
            Console.WriteLine("keliling = {0} + {1} + {2} ", alas, tinggi, miring);
            Console.WriteLine("keliling = {0} cm ", keliling);

            Console.ReadLine();
        }
    }
}
