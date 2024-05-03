using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluasi3_1_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("masukkan nilai bawah : ");
            x = int.Parse(Console.ReadLine());
            Console.Write("masukkan nilai atas : ");
            y = int.Parse(Console.ReadLine());

            for (int i =x;x<= y;x++)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine("angka " + x + " = genap");
                   
                }
                else
                {
                    Console.WriteLine("angka " + x + " = ganjil");
                    
                }
                
                    
            }
            Console.ReadLine();

        }
    }
}