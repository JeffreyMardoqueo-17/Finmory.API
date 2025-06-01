using System.ComponentModel.DataAnnotations;

namespace Finmory.API.Models
{
    /// <summary>
/// Represents a more specific classification under a category, e.g., "Groceries" under "Food".
/// </summary>
public class Subcategory
{
    public int Id { get; set; }

    [Required]
    public int CategoryId { get; set; }

    [Required, MaxLength(100)]
    public string? Name { get; set; }

    public Category? Category { get; set; }
}

}
