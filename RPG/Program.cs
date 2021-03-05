using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero Royce = new Hero("Royce", 3, 15);

            Warrior Dustin = new Warrior("Warrior Dustin", 1, 1);
            Warrior Marc = new Warrior("Warrior Marc", 3, 5);

            Knight Evol = new Knight("Knight Dustin2.0", 3, 5);
            Knight Max = new Knight("Knight Max", 5, 5);

            Monster small = new Monster("Small Monster", 5, 10, 3);
            Monster average = new Monster("Average Monster", 5, 5, 3);
            Monster big = new Monster("Big Monster", 5, 5, 5);

            Story.BeforeWarriors();
            Battle.WithWarrior(Royce, Dustin);
            Battle.WithWarrior(Royce, Marc);

            Royce.LevelUp();

            Story.BeforeKnights();
            Battle.WithKnight(Royce, Evol);
            Battle.WithKnight(Royce, Max);

            Royce.LevelUp();

            Story.BeforeMonster();
            Battle.WithMonster(Royce, small);
            Battle.WithMonster(Royce, average);
            Battle.WithMonster(Royce, big);

            Story.TheEnd();
        }
    }
}
