using System;

namespace human
{
  class Program
    {
        static void Main(string[] args)
        {
            var ninjaFactory = new NinjaFactory();
            Samurai brittany = new Samurai("Brittany");
            Ninja morgan = ninjaFactory.CreateNinja("Morgan");
            Ninja cat = ninjaFactory.CreateNinja("TacoCat");
            Wizard gandalf = new Wizard("Gandalf");
            brittany.Attack(morgan);
            brittany.Attack(morgan);
            brittany.Attack(morgan);
            brittany.Attack(morgan);
            brittany.DeathBlow(morgan);
            cat.Attack(brittany);
            gandalf.FireBall(cat);

            Console.WriteLine(brittany);
            Console.WriteLine(morgan);
            Console.WriteLine(cat);
            Console.WriteLine(gandalf);

            ninjaFactory.HowMany();
        }
    }
}
