using System;
using Microsoft.EntityFrameworkCore;

namespace mm.Models
{
  public class mmContext : DbContext
  {
    public mmContext(DbContextOptions<mmContext> options) : base(options) { }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Magazine> Magazines { get; set; }
    public DbSet<Subscription> Subscriptions { get; set; }
  }
}