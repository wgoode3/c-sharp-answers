using System;

namespace human
{
    class Ninja : Human
    {
        public Ninja(String name) : base(name, 100, 10, 10, 50)
        {
        }

        public void Steal(object obj)
        {
            this.Attack(obj);
            this.health += 10;
            Human target = obj as Human;
            if (target != null)
            {
                Console.WriteLine($"{this.name} the ninja attacked {target.name}");
            }
        }

        public void GetAway(){
            this.health -= 15;
            Console.WriteLine($"{this.name} fades into the shadows");
        }

    }
}
