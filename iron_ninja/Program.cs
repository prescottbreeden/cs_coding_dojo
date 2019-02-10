using System;
using System.Linq;

namespace iron_ninja
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Buffet nomnoms = new Buffet();
      SpiceHound ghost = new SpiceHound();
      SweetTooth lady = new SweetTooth();
      ghost.Consume(nomnoms.Serve("Sake"));
      ghost.Consume(nomnoms.Serve("Sake"));
      ghost.Consume(nomnoms.Serve("Sake"));
      ghost.Consume(nomnoms.Serve("Sake"));
      ghost.Consume(nomnoms.Serve("Pork Buns"));
      ghost.Consume(nomnoms.Serve("Sake"));
      System.Console.WriteLine(ghost.IsFull);
      ghost.FoodDiary();
      lady.Consume(nomnoms.Serve("Pork Buns"));
      lady.Consume(nomnoms.Serve("Pork Buns"));
      lady.FoodDiary();
      System.Console.WriteLine(lady.IsFull);
    }
  }
}
