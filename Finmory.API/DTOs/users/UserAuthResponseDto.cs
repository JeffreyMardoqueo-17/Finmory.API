using System;

namespace Finmory.API.DTOs.Users
{
    /// <summary>
    /// Data Transfer Object returned after a successful authentication (login or register).
    /// Includes JWT token and basic user profile info.
    /// </summary>
    public class UserAuthResponseDto
    {
        public string Token { get; set; } = string.Empty;
        public int UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LasName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? ProfilePictureUrl { get; set; }
    }
}
