using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluasi_2_2_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("masukkan angka : ");
            int a = int.Parse(Console.ReadLine());

            unsafe
            {
                int* ptr_a = &a;
                Console.WriteLine("alamat dari angka tersebut = {0} ",(int)ptr_a );
            }
            Console.ReadLine();
        }
    }
}
