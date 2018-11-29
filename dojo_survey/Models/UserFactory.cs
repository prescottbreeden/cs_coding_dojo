using System.Collections.Generic;

namespace dojo_survey.Models
{
  public static class UserFactory
  {
    public static List<User> AllUsers = new List<User>();
    static UserFactory()
    {
      AllUsers.Add(new User("Chuck Norris", "Seattle", "Python", "Rubber Baby Buggy Bumpers"));
    }
    public static User CreateUser(string name, string loc, string fav, string comment)
    {
      User newUser = new User(name, loc, fav, comment);
      AllUsers.Add(newUser);

      return newUser;
    }
  }
}
