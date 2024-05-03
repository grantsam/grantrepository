using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            began();
        }
        static void begin()
        {
            int i;
            for (i=0;i<=100;i++)
            {
                if ((i % 2) != 0) continue;
                {
                    Console.WriteLine(i); }
            }
            Console.ReadLine();
        }
        static void began()
        {

            int i = 0, j = 0, k = 0;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    for (k = 0; k < 10; k++)
                    {
                        Console.WriteLine("i,j,k: " + i + " " + j + " " + k);
                        if (k == 3)
                        {
                            goto stop;
                        }
                    }
                }
            }
        stop:

            Console.WriteLine("stopped!i,j,k: " + i + " " + j + " " + k);
            Console.ReadLine();
        }

    }
}
