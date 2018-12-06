using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicious
{
  public class Dish
  {
    [Key]
    public int dish_id { get; set; }
    public string name { get; set; }
    public string chef { get; set; }
    public int tastiness { get; set; }
    public int calories { get; set; }
    public string description { get; set; }
    
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
  }
}