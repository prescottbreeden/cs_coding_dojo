using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace mm_demo.Models
{
  public class Subscription
  {
    public int SubscriptionId { get; set; }
    public int PersonId { get; set; }
    public int MagazineId { get; set; }
    public Person Person { get; set; }
    public Magazine Magazine { get; set; }
  }
  public class Person
  {
    public int PersonId { get; set; }
    public string Name { get; set; }
    public List<Subscription> Subscriptions { get; set; }
  }
  public class Magazine
  {
    public int MagazineId { get; set; }
    public string Title { get; set; }
    public List<Subscription> Readers { get; set; }
  }
  public class ManyContext : DbContext
  {
    public ManyContext(DbContextOptions<ManyContext> options) : base(options) { }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Magazine> Magazines { get; set; }
    public DbSet<Subscription> Subscriptions { get; set; }
  }
}