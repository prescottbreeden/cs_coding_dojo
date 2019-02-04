namespace rpg
{
  class Player
  {
    protected int _health;
    public int health
    {
      get { return _health; }
      set { _health = health; }
    }
    protected string _name;
    public string name
    {
      get { return _name; }
      set { _name = name; }
    }
    
    public Player(string name)
    {
      _name = name;        
      _health = 100;
    }

  }
}
