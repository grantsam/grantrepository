using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluasi_2_1_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int z = 1;
            string c;
            Stack a = new Stack();
        cp1:
            Console.Write("push sebuah angka = ");
            int b = int.Parse(Console.ReadLine());
            
            for (int i = z; i == z ; i++)
            {
                
                a.Push(b);
            }
            Console.WriteLine();
            cp2:
            Console.Write("pilih opsi push/pop/view = ");
            c = Console.ReadLine();
            if ( c == "push")
            {
                z++;
                goto cp1;
               
            }
            else if ( c == "pop")
            {
                a.Pop();
                goto cp2;
            }
            else if (c == "view")
            {
                Console.WriteLine();
                Console.WriteLine("==== STACK ====");
                Console.WriteLine("values : ");
                printvalues(a);
            }
            else
            {
                Console.WriteLine("input tidak diketahui");
            }


            Console.ReadLine();
        }
        public static void printvalues(IEnumerable mycoll)
        {
            foreach (object obj in mycoll)
                Console.WriteLine("{0} ",obj);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
