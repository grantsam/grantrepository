using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_aritmatika_cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("masukkan nilai 1 : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("masukkan nilai 2 : ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("hasil :{0}", x/y);
            Console.ReadLine();

        }
    }
}
