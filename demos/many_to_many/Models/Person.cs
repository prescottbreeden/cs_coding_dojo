using System.Collections.Generic;

namespace many_to_many.Models
{
  public class Person
  {
    public int PersonId { get; set; }
    public string Name { get; set; }
    public List<Subscription> Subscriptions { get; set; }
  }
}