namespace human
{
  class Human
    {
        private string Name;
        private int Strength;
        private int Intelligence;
        private int Dexterity;
        private int Health;

        public Human(string name)
        {
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
            Name = name;
        }
        public Human(
            string name, 
            int str,
            int dex,
            int intelligence,
            int health)
        {
           Name = name; 
           Strength = str;
           Dexterity = dex;
           Intelligence = intelligence;
           Health = health;
        }

        public void Attack(Human target) 
        {
            target.Health -= Strength * 5;
            Health -= Strength;
            System.Console.WriteLine(Name + " attacked " + target.Name);
            System.Console.WriteLine(target.Name + " has " + target.Health + " health remaining");
        }
 
    }
}
