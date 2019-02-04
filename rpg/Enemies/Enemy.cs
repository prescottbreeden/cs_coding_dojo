namespace rpg
{
  class Enemy
  {
    protected int _health { get; set; }
    protected int _strength { get; set; }

    private int _dexterity1;

    protected int Get_dexterity()
    {
      return _dexterity1;
    }

    protected void Set_dexterity(int value)
    {
      _dexterity1 = value;
    }

    protected byte _type { get; set; }

    public int health
    {
      get { return _health; }
    }

    public string Name
    {
      get
      {
        switch (this._type)
        {
          case 0:
            System.Console.WriteLine(this._type);
            return "Bobokin";
          case 1:
            return "Moblin";
          case 2:
            return "Lizalfos";
          case 3:
            return "Turret Guardian";
          case 4:
            return "Walker Guardian";
            
          default:
            return "Jerk Horse";
        }
      }
    }

    public Enemy() { }

    public Player Attack(Player player) 
    {
      
      return player;
    }
  }
}
