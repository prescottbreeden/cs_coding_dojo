using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInheritance
{
    class Vehicle
    {
        public double Odometer { get; set; }
        public int NumPassengers { get; set; }

        public Vehicle(int num)
        {
            NumPassengers = num;
            Odometer = 0;
        }

        public Vehicle(int num, double miles)
        {
            Odometer = miles;
            NumPassengers = num;
        }

        public override string ToString()
        {
            return "I am a vehicle...?";
        }

    }
}
