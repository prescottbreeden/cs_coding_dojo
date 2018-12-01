using System;
using System.ComponentModel.DataAnnotations;

namespace validations.Models
{
  public class User
  {
    [NoFutureDate]
    private DateTime _birthdate { get; set; }

    public string Birthdate
    {
      get
      {
        return _birthdate.ToShortDateString();
      }
    }

    [Required, MinLength(3), NoZNames]
    public string Name { get; set; }

    [Required, EmailAddress]
    public string Email { get; set; }

    public User() { }

    public User(string name, string email, DateTime birthdate)
    {
      Name = name;
      Email = email;
      _birthdate = birthdate;
    }
  }
}