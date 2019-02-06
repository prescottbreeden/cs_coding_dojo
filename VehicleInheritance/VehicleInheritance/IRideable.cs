namespace VehicleInheritance
{
  interface IRideable
    {
        void Ride(double distance);
        double DistanceTraveled { get; set; }
    }
}
