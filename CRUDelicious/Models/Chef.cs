using System;
using System.Collections.Generic;

namespace CRUDelicious
{
  public class Chef
  {
    public int ChefId { get; set; }
    public string Name { get; set; }
    public List<Dish> Dishes { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
  }
}