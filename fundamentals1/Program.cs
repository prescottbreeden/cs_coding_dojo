using System;
using System.Collections.Generic;

namespace fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            string place = "Coding Dojo";
            Console.WriteLine($"Hello {place}...");
            int[] numArray = new int[5];
            int[] numArray2 = {1, 2, 3, 4, 5};
            int[] array3;
            array3 = new int[] {1, 3 , 5, 7, 9};

            for(int i = 0; i < numArray.Length; i++) 
            {
                System.Console.WriteLine(numArray[i]);
            }

            List<string> bikes = new List<string>();
            bikes.Add("Kawasaki");
            bikes.Add("Triumph");
            bikes.Add("Honda");
            bikes.Add("BMW");
            bikes.Add("Harley Davidson");
            bikes.Add("Suzuki");

            foreach(string bike in bikes) 
            {
                System.Console.WriteLine(bike);
            }

            Dictionary<string, string> profile = new Dictionary<string, string>();
            // Almost all the methods that exists with Lists are the same with Dictionaries
            profile.Add("Name", "Spreos");
            profile.Add("Language", "PHP");
            profile.Add("Location", "Greece");
            // System.Console.WriteLine("Instructor Profile");
            // System.Console.WriteLine("Name - " + profile["Name"]);
            // System.Console.WriteLine("Location - " + profile["Location"]);
            // System.Console.WriteLine("Favorite Language - " + profile["Language"]);

            foreach(KeyValuePair<string, string> entry in profile)
            {
                System.Console.WriteLine($"{entry.Key} - {entry.Value}");
            }

        }
    }
}
