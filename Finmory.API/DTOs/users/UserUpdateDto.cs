using System.ComponentModel.DataAnnotations;

namespace Finmory.API.DTOs.Users
{
    /// <summary>
    /// Data Transfer Object used to update editable user information.
    /// Excludes identity and system-managed fields.
    /// </summary>
    public class UserUpdateDto
    {
        [Required, MaxLength(100), MinLength(3)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(100), MinLength(3)]
        public string LasName { get; set; } = string.Empty;

        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [MaxLength(255)]
        public string? Password { get; set; }

        [MaxLength(500)]
        public string? ProfilePictureUrl { get; set; }
    }
}
