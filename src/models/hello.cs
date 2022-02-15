using System.ComponentModel.DataAnnotations;

namespace Models;

public class Hello
{
  [Key]
  public int Id { get; set; }
  public string Message { get; set; }
}