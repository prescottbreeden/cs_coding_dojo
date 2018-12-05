using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using validations.Models;

namespace validations.Models
{
  public class Author
  {
    [Key]
    public int author_id {get; set;}

    [Required, MinLength(3), NoZNames]
    [Display(Name = "name")]
    public string Name { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public IEnumerable<Quote> quotes { get; set; }
    public Author()
    {
      quotes = new List<Quote>();
    }
  }
}