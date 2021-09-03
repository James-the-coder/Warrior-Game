using System;
using System.Collections.Generic;
using System.Text;

namespace Warrior
{
    class Warrior
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double attkMax { get; set; }
        public double blockMax { get; set; }
        public bool potion { get; set; }

        Random random = new Random();

        public Warrior(string n, double H, double A, double B, bool p)
        {
            Name = n;
            Health = H;
            attkMax = A;
            blockMax = B;
            potion = p;
        }

        public double Attack()
        {
            return random.Next(1, (int)attkMax);
        }

        public double Block()
        {
            return random.Next(1, (int)blockMax);
        }

        public double Heal()
        {
            return Health + 30;
        }

    }
}
