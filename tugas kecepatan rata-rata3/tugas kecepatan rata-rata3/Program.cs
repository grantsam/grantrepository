using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_kecepatan_rata_rata3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x_jarak = 50, y_jarak = 90, z_jarak = 40;
            int x_waktu = 1, y_waktu = 2, z_waktu = 1;
            int kecepatan;
            Console.WriteLine("jarak A ke B = {0}km", x_jarak);
            Console.WriteLine("jarak B ke C = {0}km", y_jarak);
            Console.WriteLine("jarak C ke D = {0}km", z_jarak);
            Console.WriteLine();
            Console.WriteLine("waktu A ke B = {0} jam", x_waktu);
            Console.WriteLine("waktu B ke C = {0} jam", y_waktu);
            Console.WriteLine("waktu C ke D = {0} jam", z_waktu);
            Console.WriteLine("================================");

            //perubahan kilometer ke meter
            x_jarak = x_jarak * 1000;
            y_jarak = y_jarak * 1000;
            z_jarak = z_jarak * 1000;
            //perubahan jam ke detik
            x_waktu = x_waktu * 3600;
            y_waktu = y_waktu * 3600;
            z_waktu = z_waktu * 3600;

            Console.WriteLine("jarak A ke B = {0}m", x_jarak);
            Console.WriteLine("jarak B ke C = {0}m", y_jarak);
            Console.WriteLine("jarak C ke D = {0}m", z_jarak);
            Console.WriteLine("waktu A ke B = {0} s", x_waktu);
            Console.WriteLine("waktu B ke C = {0} s", y_waktu);
            Console.WriteLine("waktu C ke D = {0} s", z_waktu);

            kecepatan = (x_jarak + y_jarak + z_jarak) / ( x_waktu + y_waktu + z_waktu);
            Console.WriteLine("kecepatan rata-rata = ? (v)");
            Console.WriteLine(" v = m / s");
            Console.WriteLine(" v = (jarak AB + jarak BC + jarak CD) / (waktu AB + waktu BC + waktu CD)");
            Console.WriteLine(" v = ({0}m+{1}m+{2}m)/ ({3}s+{4}s+{5}s)", x_jarak, y_jarak, z_jarak, x_waktu, y_waktu, z_waktu);
            Console.WriteLine(" V = {0}m/s", kecepatan);
            Console.ReadLine();




        }
    }
}
