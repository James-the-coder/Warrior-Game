using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Warrior
{
    class battle
    {

        public static void StartFight(Player warrior1, Warrior warrior2)
        {
            while (true)
            {
                //player turn
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("|ATTACK| |INVENTORY| ");
                string choice = (Console.ReadLine()).ToLower();

                if (choice == "attack")
                {
                    if (PlayerAttack(warrior1,warrior2) == "GameOver")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(@" _    ______________________  ______  __");
                        Console.WriteLine(@"| |  / /  _/ ____/_  __/ __ \/ __ \ \/ /");
                        Console.WriteLine(@"| | / // // /     / / / / / / /_/ /\  / ");
                        Console.WriteLine(@"| |/ // // /___  / / / /_/ / _, _/ / /  ");
                        Console.WriteLine(@"|___/___/\____/ /_/  \____/_/ |_| /_/   ");
                        
                        break;
                    }
                }

                if (choice == "inventory")
                {
                    warrior1.Inventory();
                }

                //enemy turn
                if (warrior2.Health < 50 && warrior2.potion)
                {
                    warrior2.Heal();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{warrior2.Name} consumed potion health is {warrior2.Health}");
                    Console.ForegroundColor = ConsoleColor.White;
                    warrior2.potion = false;
                }
                else if (EnemyAttack(warrior1, warrior2) == "GameOver")
                {
                    Console.WriteLine(@"    __    ____  __________");
                    Console.WriteLine(@"   / /   / __ \/ ___/ ___/");
                    Console.WriteLine(@"  / /   / / / /\__ \\__ \ ");
                    Console.WriteLine(@" / /___/ /_/ /___/ /__/ /");
                    Console.WriteLine(@"/_____/\____//____/____/");
                    break;
                }


                
            }
        }

        public static string PlayerAttack(Player warriorA,Warrior warriorB)
        {
            double damage = warriorA.Attack() - warriorB.Block();
            if (damage >= 0)
            {
                warriorB.Health -= damage;
            }
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{warriorA.Name} attacked {warriorB.Name} and dealt {damage} damage");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{warriorB.Name} has {warriorB.Health} health left");
            if (warriorB.Health <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{warriorB.Name} has fallen");
                return "GameOver";
            }
            return null;
        }

        public static string EnemyAttack(Player warriorA, Warrior warriorB)
        {
            double damage = warriorB.Attack() - warriorA.Block();

            if (damage >= 0)
            {
                warriorA.Health -= damage;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{warriorB.Name} attacked {warriorA.Name} and dealt {damage} damage");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{warriorA.Name} has {warriorA.Health} health left");

            if (warriorA.Health <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{warriorA.Name} has fallen");
                return "GameOver";
            }
            return null;
        }



    }
}
