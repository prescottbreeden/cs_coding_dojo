using many_to_many.Models;
using Microsoft.EntityFrameworkCore;

namespace many_to_many
{
  public class ManyContext : DbContext
  {
    public ManyContext(DbContextOptions<ManyContext> options) : base(options) { }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Magazine> Magazines { get; set; }
    public DbSet<Subscription> Subscriptions { get; set; }
  }
}