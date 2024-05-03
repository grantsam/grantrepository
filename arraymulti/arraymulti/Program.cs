using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraymulti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriks =
            {
                {18,2,3 },
                {4,5,6 },
                {8,200,5}
            };
            Console.WriteLine("isi matriks : ");
            for (int i = 0; i < 3; i++)
            {
                
                for(int j = 0; j < 3; j++)
                {
                   
                        Console.Write($"{matriks[i, j]}");
                        Console.Write(" ");
                    
                }
                Console.WriteLine();

                
                
            }
            int a = matriks[0, 0] + matriks[1, 0] + matriks[2, 0];
            int b = matriks[0, 1] + matriks[1, 1] + matriks[2, 1];
            int c = matriks[0, 2] + matriks[1, 2] + matriks[2, 2];

            Console.WriteLine();
            if (a > 200)
            {
                Console.WriteLine("jumlah suara lebih 200 pada a");
                Console.WriteLine("jumlah kolom 1 : " + a);
                Console.WriteLine("jumlah kolom 2 : " + b);
                Console.WriteLine("jumlah kolom 3 : " + c);
            }
            else if(b > 200)
            {
                Console.WriteLine("jumlah suara lebih 200 pada b");
                Console.WriteLine("jumlah kolom 1 : " + a);
                Console.WriteLine("jumlah kolom 2 : " + b);
                Console.WriteLine("jumlah kolom 3: " + c);
            }
            else if(c > 200)
            {
                Console.WriteLine("jumlah suara lebih 200 pada c");
                Console.WriteLine("jumlah kolom 1 : " + a);
                Console.WriteLine("jumlah kolom 2 : " + b);
                Console.WriteLine("jumlah kolom 3 : " + c);
            }
            else  if ( a && b > 200)
            {

            }
            else
            {
                Console.WriteLine("jumlah kolom1 : " + a);
                Console.WriteLine("jumlah kolom2 : " + b);
                Console.WriteLine("jumlah kolom3 : " + c);
            }
            Console.ReadLine();
        }
    }
}
