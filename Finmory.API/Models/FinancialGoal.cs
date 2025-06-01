using System.ComponentModel.DataAnnotations;
using Finmory.API.Models;

namespace Finmory.API.Models
{
    /// <summary>
    /// Represents a savings goal a user wants to achieve, with a target amount and optional deadline.
    /// </summary>
    public class FinancialGoal
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public decimal TargetAmount { get; set; }

        public decimal CurrentAmount { get; set; } = 0;

        public DateTime? TargetDate { get; set; }

        public User? User { get; set; }

        public ICollection<GoalContribution> Contributions { get; set; }
    }

}
