using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 12, 1, 7, 27, 100, 72, 62 };
            Console.Write("Array original : ");
            Printarray(array);
            Console.WriteLine();
            Console.Write("Array Sorted : ");
            Bubblesort(array);
            Printarray(array);
            Console.ReadLine();        }
        
        static void Bubblesort(int[] arr)
        {
            int temp = 0;
            //bubbbblesort = (n - 1)
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                   
                    if (arr[j] > arr[j+1])
                    {
                        
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                
                }
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
