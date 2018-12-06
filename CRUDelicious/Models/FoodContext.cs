using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Models
{
  public class FoodContext : DbContext
  {
    public FoodContext(DbContextOptions<FoodContext> options) : base(options) { }
    public DbSet<Dish> dishes { get; set; }
  }
}