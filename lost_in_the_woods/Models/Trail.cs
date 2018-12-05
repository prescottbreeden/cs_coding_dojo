using System.ComponentModel.DataAnnotations;

namespace lost_in_the_woods.Models
{
  public class Trail
  {
    [Key]
    public long Id { get; set; }
    public string Name { get; set; }
    public float Length {get; set; } 
    public int Elevation { get; set; }
    public string Description { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }

    public Trail()
    {
        
    }
  }
}