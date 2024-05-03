using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selectionsort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 2, 56, 21, 14, 88, 33, 100 };
            Console.Write("array original : ");
            Printarray(array);
            Console.WriteLine();
            Console.Write("array sorted : ");
            Selectionsort(array);
            Printarray(array);
            Console.ReadLine();
        }

        static void Selectionsort(int[] arr)
        {
            int n = arr.Length;
            int min = 0;
            for (int i = 0; i < n-1; i++)
            {
                min = i;
                for(int j = i + 1; j < n; j++)
                {

                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                    
                }
                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;

            }
        }

        static void Printarray(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }
        }
    }
}
