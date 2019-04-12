using System.Collections.Generic;

namespace ProductsCategories.Models
{
  public class CategoriesPage
  {
    public string Title { get; set; } = "Categories";
    public List<Category> ExistingCategories { get; set; }
    public Category NewCategory { get; set; }
  }
}