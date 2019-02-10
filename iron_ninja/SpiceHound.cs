namespace iron_ninja
{
  class SpiceHound : Ninja
  {
    public override bool IsFull => calorieIntake >= 1200;
    public override void Consume(IConsumable item)
    {
      if (IsFull)
      {
        System.Console.WriteLine("I'm full bro.");
        return;
      }
      calorieIntake += item.Calories;
      ConsumptionHistory.Add(item);
      System.Console.WriteLine($"Eating ==> {item.GetInfo()}");
    }
    public override void FoodDiary()
    {
      System.Console.WriteLine("\n================================\n");
      foreach(IConsumable item in ConsumptionHistory)
      {
        System.Console.WriteLine(item.GetInfo());
      }
    }
  }
}
