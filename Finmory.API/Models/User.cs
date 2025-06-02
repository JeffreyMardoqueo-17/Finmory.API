using System.ComponentModel.DataAnnotations;

namespace Finmory.API.Models
{
    /// <summary>
    /// Represents a registered user in the system, who owns accounts, categories, transactions, budgets, and financial goals.
    /// </summary>
    public class User
    {
        public int Id { get; set; }

        [Required, MaxLength(100), MinLength(3), RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Username can only contain letters and numbers.")]
        public string? Name { get; set; }

        [Required, MaxLength(100), MinLength(3), RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Username can only contain letters and numbers.")]
        public string? LasName { get; set; }

        [Required, EmailAddress, MaxLength(100)]
        public string? Email { get; set; }

        [MaxLength(255)]
        public string? Password { get; set; }

        [MaxLength(500)]
        public string? ProfilePictureUrl { get; set; }

        [Required, MaxLength(250)]
        public string? AuthGoogleId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        //Navigation properties // Relaciones
    public ICollection<FinancialGoal>? FinancialGoals { get; set; }
    public ICollection<GoalContribution>? GoalContributions { get; set; }
    public ICollection<Transaction>? Transactions { get; set; }
    public ICollection<FinancialAccount>? FinancialAccounts { get; set; }
    public ICollection<Budget>? Budgets { get; set; }

    }
}