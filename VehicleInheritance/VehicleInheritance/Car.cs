 VehicleInheritance
{
  class Car : Vehicle, IRideable
  {
    public int NumberOfWheels { get; set; } = 4;
    public string Condition { get; set; }

    public double DistanceTraveled
    {
      get { return Odometer; }
      set { Odometer = value; }
    }

    public Car() : base(5)
    {
      Condition = "New";
    }

    public Car(double odo) : base(5, odo)
    {
      Condition = "Used";
    }

    public override string ToString()
    {
      return "I am a car... vroom vroom!";
    }

    public void Ride(double distance)
    {
      System.Console.WriteLine("... vroom vroom ...");
      Odometer += distance;
    }
  }
}
