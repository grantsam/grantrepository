using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
    class Program
    {
        static int Binarysearchstepbystep(int[] arr, int key)
        {
            Array.Sort(arr);
            Console.WriteLine("mencari elemen {0} dalam array yang sudah diurutkan...",key);

            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;   
                Console.WriteLine("memeriksa elemen tengah indeks {0} : {1}",mid,arr[mid]);

                if(arr[mid] == key)
                {
                    Console.WriteLine("elemen {0} ditemukan pada indeks {1}",key,mid);
                    return mid;
                }
                else if (arr[mid] < key)
                {
                    Console.WriteLine("elemen {0} lebih besar dari {1},mempersempit rentang kanan", key,arr[mid]);
                    left = mid +1;
                }
                else
                {
                    Console.WriteLine("elemen {0} lebih kecil dari {1},mempersempit rentang kiri", key, arr[mid]);
                    right = mid -1;
                }
            }
            Console.WriteLine("elemen {0} tidak ditemukan dalam array", key);
            return -1;

        }
        static void Main()
        {
            int[] arr = {2, 4, 6, 8, 10, 12, 14, 16, 18};
            int key = 10;
            int index = Binarysearchstepbystep(arr, key);

            if ( index != 1)
            {
                Console.WriteLine("elemen {0} ditemukan [ada indeks {1}",key,index);
            }
            else
            {
                Console.WriteLine("elemen {0} tidak ditemukan dalam array",key);
            }
            Console.ReadLine();
        }
    }
}
