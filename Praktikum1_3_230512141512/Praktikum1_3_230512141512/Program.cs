using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum1_3_230512141512
{
    internal class Program
    {
        static void Main(string[]args)
        {
            int gaji = 20000000;
            int tunjangan = 250000;
            int masakerja = 3;
            int bonus;
            int totalgaji;

            bonus = tunjangan * masakerja;
            totalgaji = gaji + bonus;
            Console.WriteLine("total bonus {0}", bonus);
            Console.WriteLine("total gaji adalah {0}", totalgaji);
            Console.ReadLine();


        }
    }
}
