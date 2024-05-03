using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPraktikum2_1_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int volume, rusuk;
            Console.Write("masukkan nilai rusuk : ");
            rusuk = int.Parse(Console.ReadLine());
            volume = rusuk * rusuk * rusuk;
            Console.WriteLine("volume = rusuk * rusuk * rusuk ");
            Console.WriteLine("volume = {0} * {1} * {2}", rusuk, rusuk, rusuk);
            Console.WriteLine("volume = {0} cm^3", volume);

            int permukaan = 6 * rusuk * rusuk;
            Console.WriteLine("luas permukaan = 6 * rusuk * rusuk ");
            Console.WriteLine("luas permukaan = 6 * {0} * {1}", rusuk, rusuk);
            Console.WriteLine("luas permukaan = {0} cm^2",permukaan);

            Console.ReadLine();

        }
    }
}
