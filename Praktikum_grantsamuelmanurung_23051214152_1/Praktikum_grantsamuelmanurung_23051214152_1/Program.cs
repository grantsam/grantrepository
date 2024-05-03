using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum_grantsamuelmanurung_23051214152_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linked = new LinkedList<string>();
            linked.AddLast("honda");
            linked.AddLast("yamaha");
            linked.AddLast("pria");
            linked.AddFirst("Grant samuel manurung");

            foreach(var item in linked)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
