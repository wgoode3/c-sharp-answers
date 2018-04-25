using System;

namespace human
{
    class Human
    {
        public string name { get; set; }
        public int health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }

        public Human(string name)
        {
            this.name = name;
            this.health = 100;
            this.strength = 3;
            this.intelligence = 3;
            this.dexterity = 3;
        }

        public Human(string name, int health, int strength, int intelligence, int dexterity)
        {
            this.name = name;
            this.health = health;
            this.strength = strength;
            this.intelligence = intelligence;
            this.dexterity = dexterity;
        }
        public void Attack(object obj)
        {
            Human target = obj as Human;
            if (target != null)
            {
                int damage = this.strength * 5;
                target.health -= damage;
                Console.WriteLine($"{this.name} attacked {target.name} for {damage} damage");
            }
            else
            {
                Console.WriteLine("Failed to attack");
            }
        }

    }
}
