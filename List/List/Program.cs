using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
     class Program
    {
        
        static void Main()
        {
            Main2();
        }
        static void Main2()
        {
            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            Console.Write("isi list :");

            foreach (object obj in list)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();

            Console.WriteLine("elemen ke-3 : " + list[2]);
            list[2] = 10;//change list to 10

            Console.WriteLine("isi list setelah diubah : ");
            foreach (object obj in list)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        static void main3()
        {
            List<string> list = new List<string>();
            list.Add("susu");
            list.Add("roti");
            list.Add("sayuran");

           
            Console.WriteLine("daftar belanjaan sblm delete : ");
            foreach ( var item in list)
            {

            }
        }
    }
}
