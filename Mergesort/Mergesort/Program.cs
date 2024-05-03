using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mergesort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 5, 1, 24 , 12, 22, 8, 100 };
            Console.Write("array origin : ");
            Printarray(array);
            Console.WriteLine();
            Console.Write("array sorted : ");
            Mergesort(array,0,array.Length-1);
            Printarray(array);
            Console.ReadLine();
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

        static void Merge(int[] arr, int left, int mid,int right)
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

            foreach (int num in arr)
            {
                Console.Write(num+ " ");
            }
        }
    }
}
