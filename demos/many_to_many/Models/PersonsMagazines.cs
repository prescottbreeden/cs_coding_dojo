using System.Collections.Generic;

namespace many_to_many.Models
{
  public class PersonsMagazines
  {
    public List<Person> people { get; set; }
    public List<Magazine> mags { get; set; }
  }
}
