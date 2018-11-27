using System;

namespace Phone
{
    abstract class Phone
    {
        public string name;
        private string _versionNumber;
        private int _batteryPercentage;
        private string _carrier;
        private string _ringTone;

        public Phone(string versionNum, int battPercent, string carrier, )
        {
        }
    }
    class Program
    {
        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
