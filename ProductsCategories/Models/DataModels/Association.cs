namespace ProductsCategories.Models
{
  public class Association : DataModel
  {
    public int AssociationId { get; set; }
    public int ProductId { get; set; }
    public int CategoryId { get; set; }

    // Entity Navigation
    public Product Product { get; set; }
    public Category Category { get; set; }
  }
}