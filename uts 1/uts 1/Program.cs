using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uts_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukkan jumlah elemen array : ");
            int a = int.Parse(Console.ReadLine());
            int[] x = new int[a];
            int b;
            int i = 1;
            int j = 1;
            for (i = 1; i <= a; i++)
            {
                Console.Write("masukkan nilai untuk elemen ke-{0} : ", i);
                b = int.Parse(Console.ReadLine());
                x[i-1] = b;
                j++;
                
            }
            Console.WriteLine();
            Console.WriteLine("array awal saat ini : ");
            for (i = 1; i < a; i++)
            {
                Console.WriteLine("Elemen ke-{0} : {1} ", i , x[i-1]);

            }
            Console.WriteLine();
           
            Console.WriteLine("pilih operasi yang anda ingin lakukan : ");
            Console.WriteLine("1. tambah elemen");
            Console.WriteLine("2. edit elemen");
            Console.WriteLine("3. hapus elemen");
            Console.WriteLine("4. keluar");
            Console.WriteLine();
            Console.Write("masukkan pilihan anda : ");
            int c = int.Parse(Console.ReadLine());
            int d = 0;
            cp1:
            if (c == 1)
            {
                a++;
                x = new int[a];
                Console.Write("masukkan elemen baru : ");
                d = int.Parse(Console.ReadLine());
                
                x[j-1] = d;
                
            }

            else if (c == 2)
            {
                Console.Write("elemen yg akan diedit : ");
                
            }
            else if (c == 4)
            {
                for (i = 1; i <= a; i++)
                {
                    Console.WriteLine("Elemen ke-{0} : {1} ", i , x[i-1]);
                }
            }
            Console.WriteLine("pilih operasi yang anda ingin lakukan : ");
            Console.WriteLine("1. tambah elemen");
            Console.WriteLine("2. edit elemen");
            Console.WriteLine("3. hapus elemen");
            Console.WriteLine("4. keluar");
            Console.WriteLine();
            Console.Write("masukkan pilihan anda : ");
            c = int.Parse(Console.ReadLine());
            goto cp1;

            Console.ReadLine();
        }
    }
}
