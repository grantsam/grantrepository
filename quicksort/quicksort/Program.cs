using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quicksort
{
     class Program
     {
        static void Main(string[] args)
        {
            int[] array = { 4, 1, 8, 3, 10, 20, 54, 23, 100 };
            int arrays = array.Length;
            Console.Write("array original : ");
            Printarray(array);
            Console.WriteLine();
            Console.Write("array sorted : ");
            Quicksort(array, 0, arrays - 1);
            Printarray(array);
            Console.ReadLine();
        }

        static int Partition(int[] arr,int low,int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;
            return i + 1;
        }

        static void Quicksort(int[] arr,int low,int high)
        {
            if (low < high)
            {
                int x = Partition(arr, low, high);

                Quicksort(arr, low, x - 1);
                Quicksort(arr, x + 1, high);
            }
        }

        static void Printarray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

     }
}
