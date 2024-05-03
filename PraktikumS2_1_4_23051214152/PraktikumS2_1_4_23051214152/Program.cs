using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikumS2_1_4_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukkan panjang array = ");
            int a = int.Parse(Console.ReadLine());
            int[]array1= new int[a];
            int[]array2= new int[a];

            for (int i = 1; i <= a; i++)
            {
                Console.Write("array1[{0}] = ", i);
                array1[i-1] =int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= a; i++)
            {
                Console.Write("array2[{0}] = ", i);
                array2[i-1]=int.Parse(Console.ReadLine());
            }

            int[]array3= array1.Concat(array2).ToArray();
            int[] sumarray3 = new int[a];
            for (int i = 0; i < a; i++)
            {
                sumarray3[i] = array1[i] + array2[i];
            }
            Console.WriteLine("hasil jumlah value tiap alamat array = ");
            foreach (var item in sumarray3)
            {
                
                Console.Write(+item + "");
            }
          
            Console.WriteLine();

            Console.WriteLine("hasil merge array = ");
            foreach (var item in array3)
            {
                Console.Write( item + " ");
            }
            Console.ReadLine();
        }
    }
}
