using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Battle
    {
        public static void IsHeroDead(Hero hero)
        {
            if (hero.health <= 0)
            {
                Console.Clear();
                Console.WriteLine("You have been killed!");
                Console.WriteLine("Better luck next time!");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        public static void PrintTheStats(Person person1, Person person2)
        {
            person1.PrintStats();
            Console.WriteLine("");
            person2.PrintStats();
            Console.WriteLine("");
        }

        public static void WithWarrior(Hero hero, Warrior warrior)
        {
            while (warrior.health > 0 && hero.health > 0)
            {
                PrintTheStats(warrior, hero);

                hero.YourTurn(hero.Choice(), warrior);

                if (warrior.health > 0)
                {
                    warrior.WarriorTurn(warrior.EChoice(), hero);
                    IsHeroDead(hero);
                }

            }

            Console.WriteLine("{0} was killed!", warrior.name);
            Console.ReadLine();
            Console.Clear();
        }

        public static void WithKnight(Hero hero, Knight knight)
        {
            while (knight.health > 0 && hero.health > 0)
            {
                PrintTheStats(knight, hero);

                hero.YourTurn(hero.Choice(), knight);

                if (knight.health > 0)
                {
                    knight.KnightTurn(knight.EChoice(), hero);
                    IsHeroDead(hero);
                }
            }

            Console.WriteLine("{0} was killed!", knight.name);
            Console.ReadLine();
            Console.Clear();
        }

        public static void WithMonster(Hero hero, Monster Monster)
        {
            while (Monster.health > 0 && hero.health > 0)
            {
                PrintTheStats(Monster, hero);

                hero.YourTurn(hero.Choice(), Monster);

                if (Monster.health > 0)
                {
                    Monster.MonsterTurn(Monster.EChoice(), hero);
                    IsHeroDead(hero);
                }
            }

            Console.WriteLine("{0} was killed !", Monster.name);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
