using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace dojodachi.Models
{
  public class Dojodachi
  {
    public int Happiness { get; set; }
    public int Fullness { get; set; }
    public int Energy { get; set; }

    public int Meals { get; set; }

    public string Image { get; set; }

    public Dojodachi()
    {
       Happiness = 20;
       Fullness = 20;
       Energy = 50;
       Meals = 3; 
       Image = "~/images/dachi1.png";
    }

    public void UpdateImage()
    {
      if (Happiness <= 0 || Energy <= 0 || Fullness <= 0)
      {
       Image = "~/images/death.png";
      }
    }
  }
}