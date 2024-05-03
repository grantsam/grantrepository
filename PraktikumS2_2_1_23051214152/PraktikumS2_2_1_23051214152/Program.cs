using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikumS2_2_1_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int age = 32;
                int* age_ptr;
                age_ptr = &age;
                Console.WriteLine("age = {0}", age);
                Console.WriteLine(" age_ptr = {0}",*age_ptr);
                Console.WriteLine();
                age = 35;
                Console.WriteLine("nilai age_ptr setelah update = {0}", *age_ptr);
                Console.ReadLine();
            }
        }
    }
}
