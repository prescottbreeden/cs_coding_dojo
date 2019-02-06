namespace VehicleInheritance
{
  class Horse : IRideable
  {
    public string Name { get; set; }
    public double Endurance { get; set; }
    public double DistanceTraveled { get; set; }

    public Horse(string name, double endurance)
    {
      Name = name;
      Endurance = endurance;
      DistanceTraveled = 0;
    }

    public void Ride(double distance)
    {
      if(distance >= Endurance)
      {
        distance = Endurance;
      }
      System.Console.WriteLine("... riding, heeeeeyahhhh ...");
      DistanceTraveled += distance;
    }
  }
}
