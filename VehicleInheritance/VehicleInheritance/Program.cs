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
        }
    }
}
