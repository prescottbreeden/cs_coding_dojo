namespace VehicleInheritance
{
  class Person
    {
        public string Name;
        public IRideable Transport;
        public double Miles;
        public Person(string name, IRideable trans)
        {
            Name = name;
            Transport = trans;
            Miles = 0;
        }

        public void GoSomewhere(double miles)
        {
          Transport.Ride(miles);
          Miles += Transport.DistanceTraveled;
        }

        public void GetInfo()
        {
          System.Console.WriteLine($"Name: {Name}");
          System.Console.WriteLine($"Miles Traveled: {Miles}");
        }
    }
}
