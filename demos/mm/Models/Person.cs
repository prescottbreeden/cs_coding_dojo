using System.Collections.Generic;

namespace mm.Models
{
  public class Person
  {
    public int PersonId { get; set; }
    public string Name { get; set; }
    public List<Subscription> Subscriptions { get; set; }
  }
}