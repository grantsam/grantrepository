using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikumS2_3_2_23051214152
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
                Console.Write("input list [{0}] : ", i);
                string b = Console.ReadLine();
                list.Add(b);
            }

        cp1:
            Console.WriteLine("==================================");
            Console.WriteLine("1.insert");
            Console.WriteLine("2.remove");
            Console.WriteLine("3.output");
            Console.WriteLine("pilih opsi (angka saja) : ");
            int c = int.Parse(Console.ReadLine());
            if (c == 1)
            {
                Console.Write("address list yang ingin di ubah : ");
                int d = int.Parse(Console.ReadLine());
                Console.Write("input list : ");
                string e = Console.ReadLine();
                list.Insert(d, e);
                goto cp1;
            }
            else if ( c == 2)
            {
                Console.Write("input list yang ingin di remove : ");
                string f = Console.ReadLine();
                list.Remove(f);
                goto cp1;
            }
            else if ( c == 3)
            {
                foreach (string b in list)
                {
                    Console.Write(b + "    ");
                }
            }
            else
            {
                Console.WriteLine("opsi salah");
                Console.WriteLine();
                goto cp1;
            }
            
            Console.ReadLine();
        }
    }
}
