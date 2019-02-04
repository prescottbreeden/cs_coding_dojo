namespace rpg
{
  class Barbarian : Player
  {
    private int _strength;
    public int strength
    {
      get { return _strength; }
    }

    public Barbarian(string name) : base(name) 
    { 
      _strength = 5;
    }

  }
}
