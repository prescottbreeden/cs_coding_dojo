using System.ComponentModel.DataAnnotations;

namespace ProductsCategories.Models
{
  public class NewCategory
  {
    [Required]
    public string Name { get; set; }
  }
}