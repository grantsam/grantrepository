using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace break_continue_goto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            begin();
        }
    }
    static void begin()
    {
        {
            char ch;
            for (; ; )
            {
                ch = (char)
                    Console.Read();
                if (ch == 'q') break;
            }
            Console.WriteLine("you pressed q");
        }
    }

    static void begin2()
    {
        for(int i=0;i<3;i++)
        {
            Console.WriteLine("outer loop count: " = i);
            Console.Write("inner loop count : ");
            int t = 0;
            while(t <100)
            {
                if (t == 10) break;
                Console.Write(t + " ");
                i++
            }
        }
    }


}
