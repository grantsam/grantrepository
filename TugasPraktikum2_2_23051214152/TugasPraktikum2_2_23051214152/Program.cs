using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPraktikum2_2_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int panjang, lebar,tinggi, volume;
            Console.Write("masukkan panjang : ");
            panjang = int.Parse(Console.ReadLine());
            Console.Write("masukkan lebar : ");
            lebar = int.Parse(Console.ReadLine());
            Console.Write("masukkan tinggi : ");
            tinggi = int.Parse(Console.ReadLine());
            volume = panjang * lebar * tinggi;
            Console.WriteLine("volume = panjang * lebar * tinggi");
            Console.WriteLine("volume = {0} * {1} * {2}", panjang, lebar, tinggi);
            Console.WriteLine("volume = {0} cm^3", volume);

            int PL = panjang * lebar;
            int PT = panjang * tinggi;
            int LT = lebar * tinggi;

            int permukaan;
            permukaan = 2 * ((panjang * lebar) + (panjang * tinggi) + (lebar * tinggi));
            Console.WriteLine("luas permukaan = 2((panjang * lebar) + (panjang * tinggi) + (lebar * tinggi)) ");
            Console.WriteLine("luas permukaan = 2(({0} * {1}) + ({2} * {3}) + ({4} * {5}))", panjang, lebar, panjang, tinggi, lebar, tinggi);
            Console.WriteLine("luas permukaan = 2(({0}) + ({1}) + ({2}))", PL, PT, LT);
            Console.WriteLine("luas permukaan = {0} cm^2", permukaan);

            Console.ReadLine();
        }
    }
}
