using System;

namespace Finmory.API.DTOs.Users
{
    /// <summary>
    /// Data Transfer Object used to return user information to the client.
    /// Does not expose sensitive data like passwords.
    /// </summary>
    public class UserReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LasName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? ProfilePictureUrl { get; set; }
        public string AuthGoogleId { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
    }
}
