using System;

namespace phone
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Nokia bob = new Nokia("1337", 25, "Verizon", "Banana Phone");
      bob.DisplayInfo();
    }
  }
}
