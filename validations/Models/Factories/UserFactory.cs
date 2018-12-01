using System;
using System.Collections.Generic;

namespace validations.Models
{
  public static class UserFactory
  {
    public static List<User> AllUsers = new List<User>();

    static UserFactory()
    {
      NewUser("Chuck Norris", "chuck@gmail.com", new DateTime(1983, 3, 1));
      NewUser("Bugs Bunny", "bugs@gmail.com", DateTime.Now.AddDays(-3000));
      NewUser("Elmer Fud", "fud@gmail.com", DateTime.Today);
    }

    public static User NewUser(User user) 
    {
      AllUsers.Add(user);
      return user;
    }

    public static User NewUser(string name, string email, DateTime bday)
    {
      User newUser = new User(name, email, bday);
      AllUsers.Add(newUser);
      return newUser;
    }
  }
}