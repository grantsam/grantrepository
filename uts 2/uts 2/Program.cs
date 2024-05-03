using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uts_2
{
    internal class Program
    {
        static void  Main(string[] args)
        {
            unsafe
            {


                Stack<int> stack = new Stack<int>();
                Console.WriteLine("push");
                Console.WriteLine("pop");
                Console.WriteLine("isempty");
                Console.WriteLine("isfull");
                Console.WriteLine("peek");
                Console.WriteLine("exit");
                Console.Write("enter your choice : ");
                int a = int.Parse(Console.ReadLine());
                int b = 0;
                int* c = &b;
                cp1:
                if (a == 1)
                {
                    Console.Write("enter elemen to push : ");
                    b = int.Parse(Console.ReadLine());
                    stack.Push(b);

                    Console.WriteLine("elemen {0} pushed onto stack  at address: {1}", b, (int)c);
                    
                }
                else if (a == 2)
                {
                    stack.Pop();
                    Console.WriteLine("elemen {0} popped from stack  at address: {1}", b, (int)c);
                }
                else if (a == 3)
                {
                    Console.Write("stack is empty : ");
                    if (stack.Count() <= 0)
                    {
                        Console.WriteLine("true");

                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
                else if (a == 4)
                {
                    Console.Write("stack is full : ");
                    if (stack.Count() >= 0)
                    {
                        Console.WriteLine("true");

                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
                else if (a == 5)
                {
                    Console.Write("peek : " + stack.Peek()) ;
                    
                }
                else if (a == 6)
                {
                    Console.WriteLine("exit");
                }
                Console.WriteLine("pop");
                Console.WriteLine("push");
                Console.WriteLine("isempty");
                Console.WriteLine("isfull");
                Console.WriteLine("peek");
                Console.WriteLine("exit");
                Console.Write("enter your choice : ");
                a = int.Parse(Console.ReadLine());
                goto cp1;
                Console.ReadLine();
            }
        }
    }
}
