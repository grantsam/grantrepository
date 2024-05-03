using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace EvaluasiS2_2_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("banyak baris = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("banyak kolom = ");
            int b = int.Parse(Console.ReadLine());
            int c = 0;
            int[,] x = new int[a, b];
            Console.WriteLine();
            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    Console.Write("matriks[{0},{1}] = ",i,j);
                    c =int.Parse(Console.ReadLine());
                    x[i,j] = c;
                }        
            }
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(x[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            repeat:
            Console.WriteLine("ubah nilai? y/n : ");
            string d = Console.ReadLine();




            if (d == "y")
            {
                Console.Write("baris yang ingin diubah : ");
                int e = int.Parse(Console.ReadLine());
                Console.Write("kolom yang ingin diubah : ");
                int f = int.Parse(Console.ReadLine());
                Console.Write("matriks[{0},{1}] = ", e-1, f-1);
                int g = int.Parse(Console.ReadLine());


                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {

                        x[e - 1, f - 1] = g;
                        Console.Write(x[i, j] + " ");
                    }
                    Console.WriteLine();

                }

            }
            else
            {
                Console.WriteLine("selesai");
                Console.ReadLine();
            }
                

            
            goto repeat;
            Console.ReadLine();
        }
    }
}
