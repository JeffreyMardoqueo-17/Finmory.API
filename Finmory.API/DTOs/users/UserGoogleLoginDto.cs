using System.ComponentModel.DataAnnotations;

namespace Finmory.API.DTOs.Users
{
    /// <summary>
    /// Data Transfer Object used for logging in or registering a user via Google Sign-In.
    /// Requires the Google authentication identifier.
    /// </summary>
    public class UserGoogleLoginDto
    {
        [Required, MaxLength(250)]
        public string AuthGoogleId { get; set; } = string.Empty;

        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string LasName { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? ProfilePictureUrl { get; set; }
    }
}
