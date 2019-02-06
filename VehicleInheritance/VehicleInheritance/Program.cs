using System;

namespace VehicleInheritance
{
  class Program
    {
        static void Main(string[] args)
        {
            Vehicle motorcycle = new Vehicle(1);
            Console.WriteLine(motorcycle);

            Car beater = new Car(599299);
            Console.WriteLine(beater);

            Horse jerk = new Horse("Jerk Face", 500);
            Person bob = new Person("Bob", jerk);
            bob.GoSomewhere(500);
            bob.GetInfo();
        }
    }
}
