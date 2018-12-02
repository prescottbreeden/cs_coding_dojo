using System;

namespace quoting_dojo.Models
{
  public class Author
  {
    public int Id { get; set; }
    public string Name { get; set; }

    public string Quote { get; set; }

    public Author() { }

    public Author(Author author)
    {
        
    }

    public Author(string name, string quote)
    {
        Name = name;
        Quote = quote;
    }

    
  }
}