using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikumS2_1_3_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input panjang array = ");
            int a= int.Parse(Console.ReadLine());
            int[]b=new int[a];
            string r = "";
            for(int i=1;i<=a;i++)
            {
                Console.Write("array[{0}]=", i);
                b[i-1]=int.Parse(Console.ReadLine());

                if(b[i - 1]%2!=0)
                {
                    r = r + b[i-1] + " ";
                }

            }
            Console.WriteLine("nilai ganjil = " + r);
            Console.ReadLine();

        }
    }
}
