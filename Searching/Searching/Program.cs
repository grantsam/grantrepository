using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    class seqonsoluentialsearch
    {
        static int Sequentialsearchstepbystep(int[] arr, int key)
        {
            Console.WriteLine("mencari elemen {0} dalam array...", key);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("memeruksa elemen indeks {0} : {1}", i, arr[i]);
                if (arr[i] == key)
                {
                    Console.WriteLine("elemen {0} ditemukan pada indeks {1}", key,i);
                    return i;
                }
                
            }
            Console.WriteLine("elemen {0} tidak ditemukan dalam array", key);
            return -1;
        }


        static void Main()
        {
            int[] arr = { 13, 71, 19, 11, 15, 62, 4, 8, 2 };
            int key = 15;
            int index = Sequentialsearchstepbystep(arr, key);
            if (index != -1)
            {
                Console.WriteLine("elemen {0} ditemukan pada indeks {1}", key, index);

            }
            else
            {
                Console.WriteLine("elemen {0} tidak ditemukan dalam array", key);
            }
            Console.ReadLine();
           
        }
    
  
        
    }
}
