using System.ComponentModel.DataAnnotations;

namespace Finmory.API.Models
{
    /// <summary>
    /// Represents a category used to classify transactions, such as "Food", "Salary", or "Utilities".
    /// Can be of type Income or Expense.
    /// </summary>

    public class Category //categoria
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(10)]
        public string Type { get; set; } // Income, Expense

        public User? User { get; set; }

        public ICollection<Subcategory> Subcategories { get; set; }
    }

}

