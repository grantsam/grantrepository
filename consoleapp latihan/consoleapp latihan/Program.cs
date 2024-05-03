using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp_latihan
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Masukkan bilangan bulat pertama:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Masukkan bilangan bulat kedua:");
            int number2 = int.Parse(Console.ReadLine());

            int hasil = number1 + number2;
            Console.WriteLine($"Hasil  {number1} + {number2} = {hasil}");

            Console.ReadLine(); // Menahan aplikasi agar tidak langsung keluar

            //int => bilangan bulat5
            //double => bilangan desimal
            //string =>tulisan (dapat menuliskan angka tetapi tidak bisa mengolah angkanya jika memakai string)
            //bool =>kondisi true/false
        }
    }
}
