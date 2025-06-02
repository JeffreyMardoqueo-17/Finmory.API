using System.ComponentModel.DataAnnotations;

namespace Finmory.API.DTOs.Users
{
    /// <summary>
    /// Data Transfer Object used to capture the required information when creating a new user.
    /// This class defines only the input properties necessary for user registration.
    /// 
    /// </summary>
    public class UserCreateDto
    {
        [Required, MaxLength(100), MinLength(3), RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Name can only contain letters and numbers.")]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(100), MinLength(3), RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Last name can only contain letters and numbers.")]
        public string LasName { get; set; } = string.Empty;

        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [MaxLength(255)]
        public string? Password { get; set; }

        [MaxLength(500)]
        public string? ProfilePictureUrl { get; set; }

        [Required, MaxLength(250)]
        public string AuthGoogleId { get; set; } = string.Empty;
    }
}

//de esta forma solo lamo a las propiedades que necesito para crear un usuario,