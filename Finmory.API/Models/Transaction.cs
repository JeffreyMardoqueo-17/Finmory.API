using System.ComponentModel.DataAnnotations;
using Finmory.API.Models;

namespace Finmory.API.Models
{
    /// <summary>
    /// Represents a financial transaction such as a purchase or income entry.
    /// Includes the amount, type (Income or Expense), associated account, and optional note or attachment.
    /// </summary>
    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int AccountId { get; set; }

        public int? SubcategoryId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required, MaxLength(10)]
        public string Type { get; set; } // Income, Expense

        [Required]
        public DateTime Date { get; set; }

        [MaxLength(500)]
        public string? Note { get; set; }

        public bool IsRecurring { get; set; } = false;

        [MaxLength(500)]
        public string? AttachmentPath { get; set; }

        public User? User { get; set; }
        public FinancialAccount? Account { get; set; }
        public Subcategory? Subcategory { get; set; }
    }

}
