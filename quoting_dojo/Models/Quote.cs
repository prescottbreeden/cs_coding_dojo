using System;

namespace quoting_dojo.Models
{
  public class Quote
  {
    public int Id { get; set; }
    public string Author { get; set; }
    public string Content { get; set; }

    public Quote() { }

    public Quote(string author, string quote)
    {
        Author = author;
        Content = quote;
    }

    
  }
}