using System.Collections.Generic;

namespace ProductsCategories.Models
{
  public class CategoryPage
  {
    public string Title { get; set; } = "Category Page";
    public Category Category { get; set; }
    public List<Product> CurrentProducts { get; set; }
    public List<Product> AvailableProducts { get; set; }
  }
}