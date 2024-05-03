using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan_cs_1
{
    internal class Program
    {
        static void Main()
        {
            int p, l, luas;
            Console.Write("masukkan panjang : ");
            p = int.Parse(Console.ReadLine());
            Console.Write("masukkan lebar : ");
            l = int.Parse(Console.ReadLine());
            luas = p * l;
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine();

            Console.WriteLine("luas = {0} * {1} = {2}", p, l, luas);
            Console.ReadLine();
        
        }
    }
}
 