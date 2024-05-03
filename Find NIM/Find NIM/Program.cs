using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_NIM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linked = new LinkedList<string>();
            linked.AddLast("23051214152");
            linked.AddLast("dua");
            linked.AddLast("tiga");

            LinkedListNode<string> node = linked.Find("23051214152");
            linked.AddAfter(node, "inserted");

            foreach(var value in linked)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }
    }
    
    
}
