using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UTS_Genap_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukkan harga: ");
            int a = int.Parse(Console.ReadLine());

            if (a == 5000)
            {
                int a1 = 30122004;
                int a2;
                Console.Write("masukkan tgl lahir (format ddmmyy) : ");
                a2 = int.Parse(Console.ReadLine());
                if (a2== a1) 
                {
                    Console.WriteLine("menu");
                    Console.WriteLine("1.kopi , 2.teh , 3.coklat");
                    Console.Write("opsi : ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("selamat menikmati");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("input salah");
                    Console.ReadLine();
                }


            }
            else if (a == 10000)
            {
                int a1 = 30122004;
                int a2;
                Console.Write("masukkan tgl lahir (format ddmmyy) : ");
                a2 = int.Parse(Console.ReadLine());
                if (a2 == a1)
                {
                    Console.WriteLine("menu");
                    Console.WriteLine("1.eskopi , 2.esteh , 3.escoklat");
                    Console.Write("opsi : ");
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine("selamat menikmati");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("input salah");
                    Console.ReadLine();

                }
            }
            else { Console.WriteLine("input salah");
                Console.ReadLine();
            }
        }
    }
}
