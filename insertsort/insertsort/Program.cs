using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertsort
{
     class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 15, 2, 5, 92, 4, 14, 53, 100 };
            Console.Write("array original : ");
            Printarray(array);
            Console.WriteLine();
            Console.Write("array sorted : ");
            Insertsort(array);
            Printarray(array);
            Console.ReadLine();
        }

        static void Insertsort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        static void Printarray(int[] arr)
        {
            foreach(int item in arr)
            {
                Console.Write(item+" ");
            }
        }

    }
}
