using System.Collections.Generic;

namespace models.Models
{
  public class Stack
  {
    public int StackId { get; set; }
    public string Language { get; set; }
    public List<User> Students { get; set; } = new List<User>();

    public Stack()
    {
        // construction stuff here
    }

  }
}