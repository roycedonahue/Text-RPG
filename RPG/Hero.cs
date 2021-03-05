using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Hero : Person
    {
        public int healLvl = 7, maxhealth = 15;

        public Hero(string _name, int _attack, int _health)
            : base(_name, _attack, _health)
        {
        }
        public void LevelUp()
        {
            Console.WriteLine("You leveled up guy");
            Console.WriteLine("Attack +3");
            Console.WriteLine("Max health +10");
            Console.WriteLine("Heal +5");
            Console.ReadLine();
            Console.Clear();

            attack += 3;
            maxhealth += 10;
            health = maxhealth;
            healLvl += 5;
        }

        public void Heal()
        {
            health += healLvl;

            if (health > maxhealth)
            {
                health = maxhealth;
            }
        }
        public void SpinAttack(Enemy target)
        {
            target.health -= ((attack - 2) * 3);
        }
        public void DoubleSlash(Enemy target)
        {
            target.health -= attack * 2;
        }
        public int Choice()
        {
            bool correctInput = true;
            int choice = 0, choice2;
            while (correctInput)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Heal");
                Console.WriteLine("3. Special");

                bool test = int.TryParse(Console.ReadLine(), out choice);
                if (!test || choice > 3 || choice <= 0)
                {
                    Console.WriteLine("Thats not one of the options! Try again!");
                    Console.ReadLine();
                    continue;
                }

                if (choice == 3)
                {
                    Console.WriteLine("Choose Special:");
                    Console.WriteLine("1. Spin Attack");
                    Console.WriteLine("2. Double Slash");
                    Console.WriteLine("3. <--- Go back");

                    bool test2 = int.TryParse(Console.ReadLine(), out choice2);
                    if (!test2 || choice2 > 3 || choice2 <= 0)
                    {
                        Console.WriteLine("Thats not one of the options!");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    if (choice2 == 1)
                    {
                        choice = 4;
                    }

                    if (choice2 == 2)
                    {
                        choice = 5;
                    }
                }

                if (choice == 1 || choice == 2 || choice == 4 || choice == 5)
                {
                    break;
                }
            }
            return choice;
        }

        public void YourTurn(int decision, Enemy target)
        {
            if (decision == 1)
            {
                NormAttack(target);
                Console.WriteLine("You hit the enemy!");
            }

            if (decision == 2)
            {
                Heal();
                Console.WriteLine("You healed for {0} health!", healLvl);
            }

            if (decision == 4)
            {
                SpinAttack(target);
                Console.WriteLine("Spin Attack!");
            }
            
            if (decision == 5)
            {
                 DoubleSlash(target);
                 Console.WriteLine("Double Slash!");
            }
            
        }
    }
}
