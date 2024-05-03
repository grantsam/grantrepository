using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikumS2_3_3_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input jumlah list : ");
            int a = int.Parse(Console.ReadLine());
            List<int> list = new List<int>(a);
            int b = 0;
            int c = 0;
            for(int i = 0; i < a; i++)
            {
                Console.Write("input nilai list [{0}] : ", i);
                b = int.Parse(Console.ReadLine());
                list.Add(b);
                c += b;
            }

            foreach(int i in list)
            {
                Console.Write(i+ "  ");

            }
            Console.WriteLine();
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
