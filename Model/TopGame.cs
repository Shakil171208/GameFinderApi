using System.ComponentModel.DataAnnotations;

public class TopGame {
    [Key]
  public int Id { get; set; }
  public int GameId { get; set; }
  public string? Name { get; set; }
  public string? Description { get; set; }
  public string? Genre { get; set; }
  public string? ImageUrl { get; set; }
  public DateTime? ReleasedDate { get; set; }
}