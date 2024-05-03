using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluasi3_4_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x;
            int a = 1;
            Console.Write("masukkan jumlah baris : ");
            x = int.Parse(Console.ReadLine());

            for(int i=1;i<=x;i++)
            {
                for (int j=1;j<=i;j++)
                {
                    
                    Console.Write(a);
                    Console.Write("    ");
                    a++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
