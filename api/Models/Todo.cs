using System;
using System.ComponentModel.DataAnnotations;

namespace api
{
  public class Todo
  {
    [Key]
    public int todo_id { get; set; }
    [MinLength(3)]
    public string title { get; set; }
    public bool is_done { get; set; }
  }
}