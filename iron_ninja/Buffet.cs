using System.Collections.Generic;

namespace iron_ninja
{
  class Buffet
  {
    public List<IConsumable> Menu = new List<IConsumable>();
    public Buffet()
    {
      StockMenu();
    }
    public void StockMenu()
    {
      Menu.Add(new Food("Example", 1000, false, false));
      Menu.Add(new Food("Soup", 500, true, false));
      Menu.Add(new Food("Soup", 500, true, false));
      Menu.Add(new Food("Soup", 500, true, false));
      Menu.Add(new Food("Soup", 500, true, false));
      Menu.Add(new Food("Pork Buns", 750, false, false));
      Menu.Add(new Food("Pork Buns", 750, false, false));
      Menu.Add(new Food("Pork Buns", 750, false, false));
      Menu.Add(new Food("Pork Buns", 750, false, false));
      Menu.Add(new Food("Pork Buns", 750, false, false));
      Menu.Add(new Drink("Sake", 200, true, true));
      Menu.Add(new Drink("Sake", 200, true, true));
      Menu.Add(new Drink("Sake", 200, true, true));
      Menu.Add(new Drink("Sake", 200, true, true));
      Menu.Add(new Drink("Sake", 200, true, true));
    }
    public IConsumable Serve(string name)
    {
      IConsumable serving = Menu.Find(ele => ele.Name == name);
      if(serving is null) { System.Console.WriteLine("Sorry sir we are out!");}
      Menu.Remove(serving);
      return serving;
    }
    public void ReadMenu()
    {
      foreach (IConsumable item in Menu)
      {
        System.Console.WriteLine(item.GetInfo());
      }
    }
  }
}
