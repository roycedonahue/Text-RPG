using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Story
    {
        public static void BeforeWarriors()
        {
            Console.WriteLine("-----------------Welcome To My RPG-----------------");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Are you prepared to fight?");
            Console.ReadLine();
            Console.Clear();
        }

        public static void BeforeKnights()
        {
            Console.WriteLine("You killed the Warriors.");
            Console.WriteLine("Well Done!");
            Console.WriteLine("The next opponent will be harder...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void BeforeMonster()
        {
            Console.WriteLine("You killed the Warriors.");
            Console.WriteLine("Well Done!");
            Console.WriteLine("The next opponent will be harder...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void TheEnd()
        {
            Console.WriteLine("You beat the game!");
            Console.WriteLine("Congradulations!");
            Console.ReadLine();
        }
    }
}
