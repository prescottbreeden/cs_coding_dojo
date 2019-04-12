using System.Collections.Generic;

namespace ProductsCategories.Models
{
  public class ProductPage
  {
    public string Title { get; set; } = "Product Page";
    public List<Category> CurrentCategories { get; set; }
    public List<Category> AvilableCategories { get; set; }
  }
}