using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikumS2_3_1_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("input jumlah list : ");
            a = int.Parse(Console.ReadLine());
            List<string> list = new List<string>(a);
            for (int i = 0; i < a; i++)
            {
                Console.Write("input list [{0}] : ",i);
                string b = Console.ReadLine();
                list.Add(b);
            }
            foreach (string b in list)
            {
                Console.WriteLine(b);
            }
            Console.ReadLine();
        }
    }
}
