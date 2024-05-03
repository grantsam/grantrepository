using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum4_4_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int i = 0;
           
            
            
                ConsoleKeyInfo keyinfo = Console.ReadKey(true);
                i++;
                if (keyinfo.Key == ConsoleKey.K)
                {
                    Console.WriteLine("kamu menekan K ,berhenti menjalankan program");
                    Console.ReadLine();
                
                    
                }
                else 
                Console.WriteLine("anak kambing +1");
                Console.WriteLine("jumlah anak kambing = " + i);
               
               
            
            
        }

    }
}
