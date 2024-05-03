using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_kecepatan_rata_rata1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jarak = 200, waktu = 25, kecepatan;
            kecepatan = jarak / waktu;

            Console.WriteLine("jarak = {0} (m)", jarak);
            Console.WriteLine("waktu = {0} (s)", waktu);
            Console.WriteLine("kecepatan rata-rata = ? (v)");
            Console.WriteLine("v = m / s");
            Console.WriteLine("v = {0}m / {1}s", jarak, waktu);
            Console.WriteLine("v = {0}m/s", kecepatan);
            Console.ReadLine();

        }
    }
}
