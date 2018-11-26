using System;

namespace human
{
    class NinjaFactory
    {
        private int _ninjas;

        public NinjaFactory()
        {
            _ninjas = 0;
        }

        public Ninja CreateNinja(string name)
        {
            _ninjas++;
            return new Ninja(name);
        }

        public void HowMany()
        {
            Console.WriteLine("Total ninjas: " + _ninjas);
        }
    }
}
