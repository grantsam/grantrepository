using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//math.sqrt /math.sin
namespace operator_cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
           
            Console.WriteLine("nilai t&&f " + (a && b));
            Console.WriteLine("nilai t||f " + (a || b));
            Console.WriteLine("nilai t!=f " + (a != b));
            Console.WriteLine();
            bool c = false;
            bool d = true;
            Console.WriteLine("nilai f&&t " + (c && d));
            Console.WriteLine("nilai f||t " + (c || d));
            Console.WriteLine("nilai f!=t " + (c != d));
            Console.WriteLine();
            bool e = true;
            bool f = true;
            Console.WriteLine("nilai t&&t " + (e &&f));
            Console.WriteLine("nilai t||t " + (e ||f));
            Console.WriteLine("nilai t!=t " + (e!= f));
            Console.WriteLine();
            bool g = false;
            bool h = false;
            Console.WriteLine("nilai f&&f " + (g &&h));
            Console.WriteLine("nilai f||f " + (g ||h));
            Console.WriteLine("nilai f!=f " + (g != h));
            Console.ReadLine();
        }
    }
}
