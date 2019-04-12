using System.Collections.Generic;

namespace ProductsCategories.Models
{
  public class Category : DataModel
  {
    public int CategoryId { get; set; }
    public string Name { get; set; }

    // Entity Navigation
    public List<Association> Associations { get; set; }
  }
}