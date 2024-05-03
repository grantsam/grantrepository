using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_time
{
    class Program
    {
        const int _max = 100000;
        static void Main(string[] args)
        {
            Main2();
            //timer
            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine();
            Main3();
            //timer
            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine();
            Main4();
            //timer
            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine();
            Main5();
            //timer
            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.ReadLine();
        }
        static void Main2()
        {
            var s1 = Stopwatch.StartNew();
            int[] array = { 3, 12, 1, 7, 27, 100, 72, 62 };
            Console.Write("Array original : ");
            Printarray(array);
            Console.WriteLine();
            Console.Write("Array bubble Sorted : ");
            Bubblesort(array);
            Printarray(array);
            Console.WriteLine();
            s1.Stop();
            Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ms"));

        }

        static void Bubblesort(int[] arr)
        {
            int temp = 0;
            //bubbbblesort = (n - 1)
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {

                    if (arr[j] > arr[j + 1])
                    {

                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }
        }

        static void Main3()
        {
            var s1 = Stopwatch.StartNew();
            int[] array = { 3, 12, 1, 7, 27, 100, 72, 62 };
            Console.Write("array original : ");
            Printarray(array);
            Console.WriteLine();
            Console.Write("array selection sorted : ");
            Selectionsort(array);
            Printarray(array);
            Console.WriteLine();
            s1.Stop();
            Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ms"));
        }

        static void Selectionsort(int[] arr)
        {
            int n = arr.Length;
            
            for (int i = 0; i < n -1 ; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
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

        static void Main4()
        {
            var s1 = Stopwatch.StartNew();
            int[] array = { 3, 12, 1, 7, 27, 100, 72, 62 };
            Console.Write("array original : ");
            Printarray(array);
            Console.WriteLine();
            Console.Write("array Heap sorted : ");
            Heapsort(array);
            Printarray(array);
            Console.WriteLine();
            s1.Stop();
            Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ms"));
        }
        static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }
            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }
            if (largest != i)
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
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                Heapify(arr, i, 0);
            }
        }
        static void Main5()
        {
            var s1 = Stopwatch.StartNew();
            int[] array = { 3, 12, 1, 7, 27, 100, 72, 62 };
            Console.Write("array origin : ");
            Printarray(array);
            Console.WriteLine();
            Console.Write("array merge sorted : ");
            Mergesort(array, 0, array.Length - 1);
            Printarray(array);
            Console.WriteLine();
            s1.Stop();
            Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ms"));

        }
        static void Mergesort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                Mergesort(arr, left, mid);
                Mergesort(arr, mid + 1, right);

                Merge(arr, left, mid, right);
            }
        }

        static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] l = new int[n1];
            int[] r = new int[n2];

            Array.Copy(arr, left, l, 0, n1);
            Array.Copy(arr, mid + 1, r, 0, n2);

            int i = 0, j = 0, k = left;
            while (i < n1 && j < n2)
            {
                if (l[i] <= r[j])
                {
                    arr[k] = l[i];
                    i++;
                }
                else
                {
                    arr[k] = r[j];
                    j++;
                }
                k++;

            }
            while (i < n1)
            {
                arr[k] = l[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = r[j];
                j++;
                k++;
            }
        }

        static void Printarray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
