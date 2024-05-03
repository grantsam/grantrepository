
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluasi3_2_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("masukkan panjang deret : ");
            x = int.Parse(Console.ReadLine());
            int z = 0;

            for (int i=1;i <=x;i++)
            {
                
                Console.Write("deret ke " + i + " = ");
                int y = int.Parse(Console.ReadLine());

                z = z + y;
  
            }
            Console.WriteLine("jumlah deret = "+z);
            Console.ReadLine();
        }
    }
}
