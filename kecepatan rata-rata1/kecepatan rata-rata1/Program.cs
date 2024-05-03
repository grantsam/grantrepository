using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kecepatan_rata_rata1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jarak = 110, waktu = 2, kecepatan;
            Console.WriteLine("jarak = {0} kilometer (km)", jarak);
            Console.WriteLine("waktu = {0} jam (h)", waktu);
            jarak = jarak * 1000; 
            waktu = waktu * 60 * 60; // 60 * 60 karena perubahan jam > menit > detik
            Console.WriteLine("jarak = {0} meter (m)", jarak);
            Console.WriteLine("waktu = {0} detik (s)", waktu);
            kecepatan = jarak / waktu;
            Console.WriteLine("kecepatan rata-rata = ? (v)");
            Console.WriteLine(" v = m / s ");
            Console.WriteLine(" v = {0}m / {1}s", jarak, waktu);
            Console.WriteLine(" v = {0} m/s", kecepatan);
            Console.ReadLine();
        }
    }
}
