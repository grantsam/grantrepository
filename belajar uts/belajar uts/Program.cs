using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace belajar_uts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            array();
        }

        static void array()
        {
            
            int[] a = new int[5];
            a[0] = 1;
            a[1] = 2;
            a[2] = 3;
            a[3] = 4;
            tot:
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);

            }
        
            Console.WriteLine("input : ");
            int b = int.Parse(Console.ReadLine());

            goto tot;
            Console.ReadLine();

        }
    }
}
