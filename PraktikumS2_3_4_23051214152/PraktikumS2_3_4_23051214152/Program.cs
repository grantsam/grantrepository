using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikumS2_3_4_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input panjang list : ");
            int a = int.Parse(Console.ReadLine());
            List<int> list = new List<int>(a);
            
            for (int i = 0; i < a; i++)
            {
                Console.Write("input value list [{0}] : ", i);
                int b = int.Parse(Console.ReadLine());
                list.Add(b);

            }

            foreach(int i in list)
            {
                Console.Write(i + "   ");

            }
            Console.WriteLine();
            list.Sort();
            Console.WriteLine("===== List setelah disort =====");
            foreach(int i in list)
            {
                Console.Write(i + "   ");
            }
            Console.WriteLine();
            Console.WriteLine("Value terbesar = " + list.Max());
            Console.WriteLine("Value terkecil = " + list.Min());
            Console.ReadLine();


        }
    }
}
