using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Warrior
{
    class Player
    {
        public int[] inventory = new int[2] {20,40};
        public string Name { get; set; }
        public double Health { get; set; }
        public double attkMax { get; set; }
        public double blockMax { get; set; }

        Random random = new Random();

        public Player(string n, double H, double A, double B)
        {
            Name = n;
            Health = H;
            attkMax = A;
            blockMax = B;
        }

        public double Attack()
        {
            return random.Next(1, (int)attkMax);
        }

        public double Block()
        {
            return random.Next(1, (int)blockMax);
        }

        public void Inventory()
        {
            int counter = 1;
            Console.WriteLine($"You have:");
            Console.ForegroundColor = ConsoleColor.Green;
            foreach(int item in inventory)
            {
                Console.WriteLine($"{counter}. {item}HP potion");
                counter++;
            }
            counter = 1;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("what would you like to use?");
            int choice = int.Parse(Console.ReadLine());
            
            if (choice < inventory.Length+1 && choice > 0)
            {
                Console.WriteLine($"You want to use {inventory[choice - 1]}HP potion?[y/n]");
                string choice2 = Console.ReadLine();

                if (choice2 == "y")
                {
                    Health += inventory[choice - 1];
                    Console.WriteLine($"Health +{inventory[choice - 1]}");
                    inventory = inventory.Where(val => val != inventory[choice - 1]).ToArray();
                }

                else
                {
                    Console.WriteLine("Not Used.");
                }
            }
            


        }
    }
}

