using System;
using System.Collections.Generic;

namespace models.Models
{
  public class User
  {
    public int UserId { get; set; } = 1;
    public string Name { get; set; }
    public int Age { get; set; }
    public List<int> LuckyNumbers { get; set; }

    public User(string name, int age)
    {
      LuckyNumbers = new List<int>();
      Name = name;
      Age = age;
    }
  }
}