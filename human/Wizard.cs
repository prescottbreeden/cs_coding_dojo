using System;

namespace human
{
    class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            SetHealth(50);
            Intelligence = 25;
        }
        public void Heal()
        {
            SetHealth(GetHealth() + Intelligence * 10);
        }
        public void FireBall(Human target)
        {
            if (target == null)
                throw new ArgumentNullException("target", "Fireball target cannot be null");

            Random rand = new Random();
            int damage = rand.Next(20, 50);
            Console.WriteLine(Name + " hurls a Fireball at " + target + " for " + damage + " damage");
            target.SetHealth(GetHealth() - damage);
            target.isDead();
        }
    }
}
