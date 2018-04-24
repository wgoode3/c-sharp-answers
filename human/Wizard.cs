using System;

namespace human
{
    class Wizard : Human
    {
        public int mana = 100;
        public Wizard(string name) : base(name, 50, 10, 25, 10)
        {
        }

        public void Heal()
        {
            int hp = this.intelligence * 10;
            this.health += hp;
            this.mana -= 10;
            Console.WriteLine($"{this.name} heals for {hp}");
        }

        public void Explosion(object obj)
        {
            int damage = new Random().Next(20, 50);
            Human target = obj as Human;
            if (target != null)
            {
                target.health -= damage;
                this.mana -= 50;
                Console.WriteLine($"{this.name} conjures a powerful explosion");
                if (this.name == "Megumin")
                {
                    Console.WriteLine("EKKKSSSUUUUUPPPRROOOSSSION!!!!!");
                }
            }
        }

    }
}