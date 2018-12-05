using System;
using System.ComponentModel.DataAnnotations;

namespace validations.Models
{
  public class Quote
  {
    public int quote_id { get; set; }
    public int author_id { get; set; }
    public Author author { get; set; }
    public string Content { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public Quote() { }

    public override string ToString()
    {
      return $"{quote_id} - {Content} - AuthorId: {author_id}";
    }
  }
}