using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class Recipe
{
    public int Id { get; set; }
    public string? Name { get; set; }
    [DataType(DataType.Time)]
    public TimeSpan Duration { get; set; }
    public int? Difficulty { get; set; }
    public int? NumberOfLikes { get; set; }
    public string? Ingredients { get; set; }
    public string? Process { get; set; }
    public string? TipsAndTricks { get; set; }
}