using System.Collections.Generic;

namespace ProductsCategories.Models
{
  public class Product : DataModel
  {
    public int ProductId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    // Entity Navigation
    public List<Association> Associations { get; set; }
  }
}