using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicious
{
  public class Dish
  {
    public int DishId { get; set; }
    public string Name { get; set; }
    public int Tastiness { get; set; }
    public int Calories { get; set; }
    public string Description { get; set; }
    public int ChefId { get; set; }
    public Chef Chef { get; set; }
    public List<Dish> Dishes { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
  }
}