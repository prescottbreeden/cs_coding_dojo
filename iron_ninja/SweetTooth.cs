namespace iron_ninja
{
  class SweetTooth : Ninja
  {
    public override bool IsFull { get { return calorieIntake >= 1500; } } 
    public override void Consume(IConsumable item)
    {
      if(IsFull)
      {
        System.Console.WriteLine("I'm full bro.");
        return;
      }
      calorieIntake += item.Calories;
      ConsumptionHistory.Add(item);
      item.GetInfo();
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
