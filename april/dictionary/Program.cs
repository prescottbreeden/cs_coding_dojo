using System;
using System.Collections.Generic;

namespace dictionary
{
  class Program
  {
    static void Main(string[] args)
    {

      string[] names = new string[] { "Bob", "Frank", "Sally", "Amanda" };

      List<string> flavors = new List<string>();
      flavors.Add("Vanilla");
      flavors.Add("Choco");
      flavors.Add("Strawberry");
      flavors.Add("Rocky Road");
      flavors.Add("Banana");

      // User Info Dictionary

      Dictionary<string, string> UserDictionary = new Dictionary<string, string>();

      Random rand = new Random();

      foreach (string name in names)
      {
        UserDictionary["name"] = flavors[rand.Next(names.Length)];
      }

    }
  }
}
