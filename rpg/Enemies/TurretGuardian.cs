namespace rpg
{
  class TurretGuardian : Enemy
  {
    public TurretGuardian() : base()
    {
      _strength = 20;
      Set_dexterity(0);
      _health = 500;
      _type = 0b11;
    }

    public Player Attack(Player player)
    {
      player.health = player.health - _strength * 2;
      System.Console.WriteLine("turret fires!");
      return player;
    }
  }
}