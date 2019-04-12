using System.Collections.Generic;

namespace ProductsCategories.Models
{
  public class ProductsPage
  {
    public string Title { get; set; } = "Products";
    public List<Product> ExistingProducts { get; set; }
    public Product NewProduct { get; set; }
  }
}