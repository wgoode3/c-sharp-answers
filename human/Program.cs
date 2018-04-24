using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human kazuma = new Human("Kazuma");
            Ninja chris = new Ninja("Chris");
            Samurai darkness = new Samurai("Darkness");
            Wizard megumin = new Wizard("Megumin");
            chris.Steal(kazuma);
            chris.GetAway();
            darkness.Attack(darkness);
            darkness.Meditate();
            darkness.HowMany();
            megumin.Explosion(kazuma);
        }
    }
}
