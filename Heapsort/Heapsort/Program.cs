using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Heapsort
{
     class Program
     {
        static void Main(string[] args)
        {
            int[] array = { 3, 1, 6, 2, 56, 23, 44, 24, 100 };
            Console.Write("array original : ");
            Printarray(array);
            Console.WriteLine();
            Console.Write("array sorted : ");
            Heapsort(array);
            Printarray(array);
            Console.ReadLine();
        }
        static void Heapify(int[] arr, int n,int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if(left < n && arr[left] > arr[largest])
            {
                largest = left;
            }
            if(right < n && arr[right] > arr[largest])
            {
                largest = right;
            }
            if(largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;

                Heapify(arr, n, largest);
            }
        }
        static void Heapsort(int[] arr)
        {
            int n = arr.Length;
            for(int i = n/2-1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            for(int i = n-1; i>=0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                Heapify(arr, i, 0);
            }
        }

        static void Printarray(int[] arr)
        {
            foreach(int item in arr)
            {
                Console.Write(item + " ");
            }
        }

     }
}
