namespace dojo_survey.Models
{
  public class User
  {
    public string Name { get; set; }
    public string DojoLocation { get; set; }
    public string FavoriteLanguage { get; set; }
    public string Comment { get; set; }
    public User(string name, string loc, string fav, string comment)
    {
      Name = name;
      DojoLocation = loc;
      FavoriteLanguage = fav;
      Comment = comment;
    }
  }
}
