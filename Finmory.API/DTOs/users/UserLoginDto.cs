using System.ComponentModel.DataAnnotations;

namespace Finmory.API.DTOs.Users
{
    /// <summary>
    /// Data Transfer Object used for user login with email and password credentials.
    /// </summary>
    public class UserLoginDto
    {
        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required, MaxLength(255)]
        public string Password { get; set; } = string.Empty;
    }
}
