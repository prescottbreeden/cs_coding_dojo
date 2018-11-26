namespace human
{
    class Samurai : Human
    {
        private const int MaxHealth = 200;
        public Samurai(string name) : base(name)
        {
            SetHealth(MaxHealth);
        }

        public void DeathBlow(Human target)
        {
            if (target.GetHealth() < 50)
            {
                System.Console.WriteLine(Name + " performs 'Death Blow' on " + target);
                target.SetHealth(0);
                target.isDead();
            }
        }

        public void meditate()
        {
            SetHealth(MaxHealth);
        }
    }
}
