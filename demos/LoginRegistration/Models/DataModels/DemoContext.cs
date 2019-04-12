using System;
using Microsoft.EntityFrameworkCore;

namespace LoginRegistration.Models
{
  public class DemoContext : DbContext
  {
    public DemoContext(DbContextOptions options) : base(options) { }

    public DbSet<User> Users { get; set; }
  }
}