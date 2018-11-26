using System;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            for (int val = 0; val < 10; val++) {
                System.Console.WriteLine(rand.Next(2,8));
                System.Console.WriteLine(Math.Round(rand.NextDouble(), 2));
                System.Console.WriteLine(rand.Next());
            }
        }
    }
}
