
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointercs
{
     class Program
    {
        static Stack<int> GetStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(100);
            stack.Push(1000);
            stack.Push(10000);
            return stack;
        }
        static void Main()
        {
            Stack<int> stack = GetStack();
            int pop = stack.Pop();
            Console.WriteLine("---element popped from top of stack---");
            Console.WriteLine(pop);
            int peek = stack.Peek();
            Console.WriteLine("---element now at the top ---");
            Console.WriteLine(peek);
            Console.ReadLine();


                
            
        }
        
    }
}
