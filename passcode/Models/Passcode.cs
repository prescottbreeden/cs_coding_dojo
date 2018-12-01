using System;
using System.Linq;

namespace passcode.Models
{
  public class Passcode
  {
    public string Code { get; set; }
    public Passcode()
    {
      Random rand = new Random();
      const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
      Code = new string(Enumerable.Repeat(chars, 14)
        .Select(s => s[rand.Next(s.Length)]).ToArray());
    }
  }
}