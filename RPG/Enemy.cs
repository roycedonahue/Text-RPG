using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Enemy : Person
    {
        public int numberofattack;

        public Enemy(string _name, int _attack, int _health)
            : base(_name, _attack, _health)
        {
        }
        public int EChoice()
        {
            int EChoice;
            Random ran = new Random();
            EChoice = ran.Next(1, numberofattack + 1);
            return EChoice;
        }
    }
    public class Warrior : Enemy
    {
        public Warrior(string _name, int _attack, int _health)
            : base (_name, _attack, _health)
        {
            numberofattack = 2;
        }
        public void Steal(Hero target)
        {
            target.health -= attack + 2;
        }
        public void NormAttack(Hero target)
        {
            target.health -= attack + 1;
        }
        public void WarriorTurn(int choice, Hero target)
        {
            if (choice == 1)
            {
                NormAttack(target);
                Console.WriteLine("Warrior attacked you!");
            }
            if (choice == 2)
            {
                Steal(target);
                Console.WriteLine("Warrior stole from you!");
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
    public class Knight : Enemy
    {
        public Knight(string _name, int _attack, int _health)
            : base (_name, _attack, _health)
        {
            numberofattack = 3;
        }
        public void NormAttack(Hero target)
        {
            target.health -= attack + 1;
        }
        public void Bang(Hero target)
        {
            target.health -= attack + 7;
        }

        public void SheildHit(Hero target)
        {
            target.health -= attack + 3;
        }

        public void KnightTurn(int choice, Hero target)
        {
            if (choice == 1)
            {
                NormAttack(target);
                Console.WriteLine("Knight hit you!");
            }

            if (choice == 2)
            {
                Bang(target);
                Console.WriteLine("Knight slashed you!");
            }
            if (choice == 3)
            {
                SheildHit(target);
                Console.WriteLine("Knight slammed you with his shield!");
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
    public class Monster : Enemy
    {
        public Monster(string _name, int _attack, int _health, int _armor)
            : base(_name, _attack, _health)
        {
            numberofattack = 4;
        }
        public void NormAttack(Hero target)
        {
            target.health -= attack + 1;
        }
        public void Beat(Hero target)
        {
            target.health -= attack * 2;
        }

        public void Claw(Hero target)
        {
            target.health -= attack + 3;
        }

        public void Bite(Hero target)
        {
            target.health -= attack + 4;
        }

        public void MonsterTurn(int choice, Hero target)
        {
            if (choice == 1)
            {
                NormAttack(target);
                Console.WriteLine("Monster hit you!");
            }

            if (choice == 2)
            {
                Beat(target);
                Console.WriteLine("Dragon headbutt you!");
            }

            if (choice == 3)
            {
                Claw(target);
                Console.WriteLine("Dragon clawed you!");
            }

            if (choice == 4)
            {
                Bite(target);
                Console.WriteLine("Dragon bite you!");
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}
