using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finmory.API.Models;

namespace Finmory.API.Repositories
{
    /// <summary>
    /// Contract for user data operations in a personal finance app.
    /// Since the app is single-user per account, methods focus on getting, updating, and validating the user's own data.
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Gets the user by their unique ID.
        /// </summary>
        Task<User> GetUserByIdAsync(int id);

        /// <summary>
        /// Adds a new user to the system (registration).
        /// </summary>
        Task AddUserAsync(User user);

        /// <summary>
        /// Updates the user's profile information.
        /// </summary>
        Task UpdateUserAsync(User user);

        /// <summary>
        /// Checks if an email is already registered (to avoid duplicates).
        /// </summary>
        Task<bool> ExistsByEmailAsync(string email);

        /// <summary>
        /// Gets the user by their email address (for login).
        /// </summary>
        Task<User> GetUserByEmailAsync(string email);

        /// <summary>
        /// Gets the user by their Google Auth ID (for Google login).
        /// </summary>
        Task<User> GetUserByGoogleAuthIdAsync(string googleAuthId);

        /// <summary>
        /// Updates only the profile picture URL.
        /// </summary>
        Task UpdateProfilePictureAsync(int userId, string profilePictureUrl);

        /// <summary>
        /// Changes the user's password securely.
        /// </summary>
        Task ChangePasswordAsync(int userId, string newPassword);
    }

}