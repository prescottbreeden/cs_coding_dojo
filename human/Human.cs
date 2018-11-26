namespace human
{
    class Human
    {
        protected string Name { get; set; }
        protected int Strength { get; set; }
        protected int Intelligence { get; set; }
        protected int Dexterity { get; set; }
        private int _health;

        public int GetHealth()
        {
            return _health;
        }

        public void SetHealth(int value)
        {
            _health = value;
        }

        public Human(string name)
        {
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            SetHealth(100);
            Name = name;
        }
        public Human(string name, int str, int dex, int intelligence, int health)
        {
            Name = name;
            Strength = str;
            Dexterity = dex;
            Intelligence = intelligence;
            SetHealth(health);
        }

        public void Attack(Human target)
        {
            System.Console.WriteLine(Name + " attacked " + target);
            target.SetHealth(target.GetHealth() - Strength * 5);
            SetHealth(GetHealth() - Strength);
            System.Console.WriteLine(target.Name + " now has " + target.GetHealth() + " health remaining");
            target.isDead();
            isDead();
        }

        public void isDead()
        {
            if (GetHealth() <= 0)
                System.Console.WriteLine(Name + " has fallen in battle...");
        }

        public override string ToString()
        {
            return $"{Name} - HP: {_health}";
        }

    }
}
