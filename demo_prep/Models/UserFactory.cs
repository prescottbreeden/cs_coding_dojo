using System.Collections.Generic;
using demo_prep.Models;

namespace demo_prep.Models
{
  public static class UserFactory
  {
    public static List<User> AllUsers = new List<User>();

    static UserFactory()
    {
      NewUser("Chuck Norris", "chuck@gmail.com", "Universe");
      NewUser("Elmer Fud", "fud@gmail.com", "Wabbit Twacks");
    }

    public static User NewUser(string name, string email, string location)
    {
      User newUser = new User(name, email, location);
      AllUsers.Add(newUser);
      return newUser;
    }
    
    public static User NewUser(User user)
    {
      AllUsers.Add(user);
      return user;
    }
  }
}