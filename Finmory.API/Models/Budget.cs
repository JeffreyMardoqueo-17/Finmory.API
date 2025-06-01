using System.ComponentModel.DataAnnotations;
using Finmory.API.Models;

namespace Finmory.API.Models
{
    /// <summary>
/// Represents a monthly budget assigned to a specific category for a user.
/// Helps track planned versus actual spending.
/// </summary>
    public class Budget //presup
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int Year { get; set; }

        [Required, Range(1, 12)]
        public int Month { get; set; }

        [Required]
        public decimal AssignedAmount { get; set; }

        public User? User { get; set; }
        public Category? Category { get; set; }
    }

}
