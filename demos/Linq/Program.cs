using System;
using System.Collections.Generic;

namespace Linq
{
  class Unicorn
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string MagicalPower { get; set; }

    public Unicorn(int id, string name, string magicalPower)
    {
      Id = id;
      Name = name;
      MagicalPower = magicalPower;
    }
  }

  class Program
  {
    static List<Unicorn> AllUnicorns = new List<Unicorn>();

    static void Main(string[] args)
    {
      
    }
  }
}
