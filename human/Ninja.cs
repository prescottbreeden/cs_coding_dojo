using System;

namespace human
{

    class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }

        public void Steal(Human target)
        {
            if (target == null)
                throw new ArgumentNullException("target", "Steal target cannot be null");

            Attack(target);
            SetHealth(+10);
        }

        public void GetAway()
        {
            SetHealth(-15);
        }

    }
}
