namespace demo_prep.Models
{
  public class User
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public string Location { get; set; }

    public User() { }
    public User(string name, string email, string location)
    {
       Name = name;
       Email = email;
       Location = location; 
    }
  }
}