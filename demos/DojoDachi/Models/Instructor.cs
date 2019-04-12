using System;

namespace DojoDachi.Models
{
  public class Instructor
  {
    public int Happiness { get; set; }
    public int Fullness { get; set; }
    public int Meals { get; set; }
    public int Energy { get; set; }
    private Random rand = new Random();

    public Instructor()
    {
      Happiness = 20;
      Fullness = 20;
      Meals = 3;
      Energy = 50;
    }

    public void Play()
    {
      Energy -= 5;
      Happiness += rand.Next(5, 11);
    }

    public void Feed()
    {
      if (Meals > 0)
      {
        Fullness += rand.Next(5, 11);
        Meals--;
      }
    }

    public void Sleep()
    {
      Energy += 15;
      Happiness -= 5;
      Fullness -= 5;
    }

    public void Work()
    {
      Energy -= 5;
      Meals += rand.Next(1, 4);
    }
  }
}