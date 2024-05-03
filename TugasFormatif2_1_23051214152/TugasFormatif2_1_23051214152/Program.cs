using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasFormatif2_1_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sisi, luas, keliling;
            Console.Write("masukkan panjang sisi : ");
            sisi = int.Parse(Console.ReadLine());
            

            luas = sisi * sisi;
            Console.WriteLine("luas = sisi * sisi");
            Console.WriteLine("luas = {0} * {1}", sisi, sisi);
            Console.WriteLine("luas = {0} cm",luas);
            

            keliling = 4 * sisi;
            Console.WriteLine("keliling = 4 * sisi");
            Console.WriteLine("keliling = {0} + {1} + {2} + {3}", sisi, sisi, sisi, sisi);
            Console.WriteLine("keliling = {0} cm", keliling);
            Console.ReadLine();
        }
    }
}
