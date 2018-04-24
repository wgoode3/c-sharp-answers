using System;

namespace human
{
    class Samurai : Human
    {
        private static int count = 0;
        public Samurai(string name) : base(name, 200, 20, 10, 10)
        {
            count++;
        }

        // basically the DeathBlow method
        public void TsubameGaeshi(object obj)
        {
            Human target = obj as Human;
            if (target != null)
            {
                if (target.health < 50)
                {
                    target.health = 0;
                    Console.WriteLine($"{this.name} effortlessly cut {target.name}");
                }
                else
                {
                    Console.WriteLine($"{target.name} avoided the attack");
                }
            }
        }

        public void Meditate()
        {
            this.health = 200;
            Console.WriteLine($"{this.name} healed back to full health");
        }

        public void HowMany()
        {
            Console.WriteLine($"There are {count} samurai");
        }

    }
}