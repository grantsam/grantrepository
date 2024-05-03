using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
     class Program
    {
        public static player currentplayer = new player();
        static void Main()
        {
            begin();
        }
        
        static void begin()
        {
            Console.WriteLine("Adventure!");
            Console.Write("Enter your name : ");
            currentplayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You are a new adventurer, during your first adventure, bad luck happens to you,");
            Console.WriteLine("The shadow dragon comes to attacks you with black mana orb");
            Console.WriteLine("You thrown away to the cliff wall");
            Console.WriteLine("You fainted! ");
            Console.WriteLine("The shadow dragon thought u died and go away after that");
            Console.WriteLine("After a while you wake up witch daze and trouble remembering");
            Console.WriteLine("You cant remember enything except your name...");
            Console.WriteLine("your name is " + currentplayer.name);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("you move away into the cave inside the cliff");
            Console.WriteLine("you turn around in the darkness and find a chest");
            Console.WriteLine("suddenly goblin fall over the cave and try to hit you! ");
            Console.ReadKey();
            Console.Clear();
        }
    }
     class player
        {
            public string name;
            public int coin = 0;
            public int health = 10;
            public int demage = 1;
            public int armor = 0;
            public int potion = 5; 

        }

    class encounter
    {
        //encounter generic



        //encounter 



        //encounter tools
    }

}
