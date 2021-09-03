using System;

namespace Warrior
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@" _       _____    ____  ____  ________  ____  _____");
            Console.WriteLine(@"| |     / /   |  / __ \/ __ \/  _/ __ \/ __ \/ ___/");
            Console.WriteLine(@"| | /| / / /| | / /_/ / /_/ // // / / / /_/ /\__ \ ");
            Console.WriteLine(@"| |/ |/ / ___ |/ _, _/ _, _// // /_/ / _, _/___/ / ");
            Console.WriteLine(@"|__/|__/_/  |_/_/ |_/_/ |_/___/\____/_/ |_|/____/  ");

            Console.WriteLine("YOU ARE IN A FIGHT WITH HERCULES");
            Console.WriteLine("ENTER THE NAME OF YOUR WARRIOR!: ");
            

            string name = Console.ReadLine();
            Player warr1 = new Player(name, 100, 40, 5);
            Warrior warr2 = new Warrior("Hercules", 100, 40, 5, true);

            battle.StartFight(warr1, warr2);
        }
    }
}

