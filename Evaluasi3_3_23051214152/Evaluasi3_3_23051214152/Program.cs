using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluasi3_3_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.Write("masukkan bilangan pertama = ");
            x = int.Parse(Console.ReadLine());
            Console.Write("masukkan bilangan kedua   = ");
            y = int.Parse(Console.ReadLine());
            Console.Write("masukkan bilangan ketiga  = ");
            z = int.Parse(Console.ReadLine());

            if (x < y && x < z) //untuk x bilangan terkecil
            {
                if (y < z)
                {
                    Console.WriteLine("urutan bilangan = " + x + " " + y + " " + z);
                }
                else
                {
                    Console.WriteLine("urutan bilangan = " + x + " " + z + " " + y);
                }
            }

            else if (y < x && y < z) //untuk y bilangan terkecil
            {
                if (x < z)
                {
                    Console.WriteLine("urutan bilangan = " + y + " " + x + " " + z);
                }
                else
                {
                    Console.WriteLine("urutan bilangan = " + y + " " + z + " " + x);
                }
            }
            else
            {
                if (x < y)
                {
                    Console.WriteLine("urutan bilangan = " + z + " " + x + " " + y);
                }
                else
                {
                    Console.WriteLine("urutan bilangan = " + z + " " + y + " " + x);
                }
            }
            Console.ReadLine();
        }
    }
}
