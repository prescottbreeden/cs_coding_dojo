using System.ComponentModel.DataAnnotations;

namespace ProductsCategories.Models
{
  public class NewProduct
  {
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public decimal Price { get; set; }
  }
}