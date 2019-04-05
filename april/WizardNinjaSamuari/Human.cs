namespace WizardNinjaSamuari
{
  class Human
  {
    private int _health;
    private int _strength;
    private int _dexterity;
    public int Strength
    {
      get { return _strength; }
      set { _strength = value; }
    }
    public int Dexterity
    {
      get { return _dexterity; }
    }
    public int Health
    {
      get { return _health; }
    }

    public Human(int health, int strength, int dexterity)
    {
      _health = health;
      _strength = strength;
      _dexterity = dexterity;
    }

    public Human()
    {
      _health = 100;
      Strength = 50;
      _dexterity = 3;
    }
  }
}
