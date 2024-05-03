using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasFormatif2_2_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int panjang, lebar, luas, keliling;
            Console.Write("masukkan panjang : ");
            panjang = int.Parse(Console.ReadLine());
            Console.Write("masukkan lebar : ");
            lebar = int.Parse(Console.ReadLine());

            luas = panjang * lebar;
            Console.WriteLine("luas = panjang * lebar");
            Console.WriteLine("luas = {0} * {1}", panjang, lebar);
            Console.WriteLine("luas = {0} cm", luas);

            int panjang2 = 2 * panjang;
            int lebar2 = 2 * lebar;
            keliling = (2 * panjang) + (2 * lebar);
            Console.WriteLine("keliling = (2 * panjang) + (2 * lebar) ");
            Console.WriteLine("keliling = (2 * {0}) + (2 * {1}) ",panjang,lebar);
            Console.WriteLine("keliling = ({0}) + ({1})", panjang2, lebar2);
            Console.WriteLine("keliling = {0} cm", keliling);

            Console.ReadLine();
        }
    }
}
