using System.ComponentModel.DataAnnotations;

namespace Finmory.API.Models
{
    /// <summary>
    /// Represents a user contribution toward a financial goal, with an amount and date.
    /// </summary>
    public class GoalContribution
    {
        public int Id { get; set; }

        [Required]
        public int GoalId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        [MaxLength(255)]
        public string? Note { get; set; }

// 🔗 Navegación
        public FinancialGoal? FinancialGoal { get; set; }
        public int FinancialGoalId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }

}
