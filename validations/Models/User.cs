using System;
using System.ComponentModel.DataAnnotations;

namespace validations.Models
{
  public class User
  {

    [Required, MinLength(3), NoZNames]
    [Display(Name = "name")]
    public string Name { get; set; }

    [Required, EmailAddress]
    [Display(Name = "email")]
    public string Email { get; set; }

    [Required, NoFutureDate]
    [Display(Name = "birthdate")]
    public DateTime? Birthdate { get; set; }

    [MinLength(20, ErrorMessage = "Comments must be 20 characters or more.")]
    public string Comment { get; set; }

    public User() { }

    public User(string name, string email, DateTime birthdate)
    {
      Name = name;
      Email = email;
      Birthdate = birthdate;
    }

    public User(string name, string email, DateTime birthdate, string comment)
    {
      Name = name;
      Email = email;
      Birthdate = birthdate;
      Comment = comment;
    }
  }
}