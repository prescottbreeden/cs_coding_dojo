namespace VehicleInheritance
{
    class Car : Vehicle
    {
        private int NumberOfWheels = 4;
        private string Condition;

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
    }
}
