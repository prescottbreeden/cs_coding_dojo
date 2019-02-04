namespace rpg
{
  class Moblin : Enemy
  {
    int _strength = 2;
    int _dexterity = 2;
    int _health = 40;
    byte _type = 0b1;

    public Moblin() : base() { }
  }
}