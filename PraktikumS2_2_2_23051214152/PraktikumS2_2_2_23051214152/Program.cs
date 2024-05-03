using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikumS2_2_2_23051214152
{
    public class Program
    {
        public static void Main()
        {
            //create and initialize new stack
            Console.Write("input jumlah stack : ");
            int a = int.Parse(Console.ReadLine());
            Stack mystack = new Stack(a);
            string x;
            for(int i = 1; i <= a; i++)
            {
                Console.Write("stack {0} = ",i);
                x = Console.ReadLine();
                mystack.Push(x);

            }

            //display 
            Console.WriteLine("mystack");
            Console.WriteLine("\tcount:       {0}", mystack.Count);
            Console.Write("\tvalues: ");
            PrintValues(mystack);
        }
        public static void PrintValues(IEnumerable mycoll)
        {
            foreach (object obj in mycoll)
                Console.Write("    {0}", obj);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
