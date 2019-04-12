using Microsoft.EntityFrameworkCore;

namespace ProductsCategories.Models
{
  public class ProductsContext : DbContext
  {
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Association> Associations { get; set; }

    public ProductsContext(DbContextOptions options) : base(options) { }

  }
}