using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Finmory.API.Models;

namespace Finmory.API.Models
{
    /// <summary>
    /// Represents a financial account (e.g., cash, wallet, bank) associated with a user.
    /// </summary>
    public class FinancialAccount //Cuenta Financiera
    {

        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(50)]
        public string AccountType { get; set; } // Cash, Wallet, Bank

        [Required, MaxLength(10)]
        public string Currency { get; set; }

        [Required]
        public decimal InitialBalance { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public User? User { get; set; }
    }

}
