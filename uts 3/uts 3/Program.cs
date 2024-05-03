using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace uts_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe {
                
                Console.WriteLine("choose operation : ");
                Console.WriteLine("1.Add element");
                Console.WriteLine("2.remove element");
                Console.WriteLine("3.view element");
                Console.WriteLine("4.exit");
                List<int> list = new List<int>();
                Console.Write("enter your choice : ");
                int a = int.Parse(Console.ReadLine());
                int c = 0;
                int b = 0;
                int* d = &b;
                cp1:5
                if (a == 1)
                {
                    Console.Write("enter element to add : ");
                    b = int.Parse(Console.ReadLine());
                    list.Add(b);
                    
                    Console.WriteLine("element {0} added to position {1} ", b, c);
                    Console.WriteLine("address of element : {0} ", (int)d);
                    c++;
                }
                else if (a == 2)
                {
                    Console.Write("enter element to remove : ");
                    b = int.Parse(Console.ReadLine());
                    list.Remove(b);
                    Console.WriteLine("element {0} added to position {1} ", b, c);
                    Console.WriteLine("address of element : {0} ", (int)d);

                }
                else if (a == 3)
                {
                    Console.WriteLine("element inthe list : ");
                    foreach (object obj in list)
                    {
                        Console.WriteLine("index : " + obj);
                        Console.WriteLine("address of element : {0} ", (int)d);
                    }
                }
                Console.WriteLine("choose operation : ");
                Console.WriteLine("1.Add element");
                Console.WriteLine("2.remove element");
                Console.WriteLine("3.view element");
                Console.WriteLine("4.exit");
                Console.Write("enter your choice : ");
                a = int.Parse(Console.ReadLine());
                goto cp1;
                Console.ReadLine();
            }
        }
    }
}
