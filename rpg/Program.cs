using System;

namespace rpg
{
  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Bobokin bob = new Bobokin();
            TurretGuardian asshole = new TurretGuardian();
            Player dingle = new Player("Dingle");
            System.Console.WriteLine(bob.Name);
            System.Console.WriteLine(asshole.Name);
            System.Console.WriteLine(asshole.health);
            System.Console.WriteLine("--------");
            System.Console.WriteLine(dingle.health);
            asshole.Attack(dingle);
            System.Console.WriteLine(dingle.health);
        }
    }
}
