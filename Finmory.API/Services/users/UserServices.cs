using AutoMapper;
using Finmory.API.DTOs.Users;
using Finmory.API.Models;
using Finmory.API.Repositories;
using Microsoft.AspNetCore.Identity;

namespace Finmory.API.Services.Users
{
    public class UserService 
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IPasswordHasher<User> _passwordHasher;

        public UserService(IUserRepository userRepository, IMapper mapper, IPasswordHasher<User> passwordHasher)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _passwordHasher = passwordHasher;
        }

        public async Task<UserReadDto> GetByIdAsync(int id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            return _mapper.Map<UserReadDto>(user);
        }

        public async Task<UserReadDto> RegisterAsync(UserCreateDto dto)
        {
            if (await _userRepository.ExistsByEmailAsync(dto.Email))
                throw new InvalidOperationException("Email is already in use.");

            var user = _mapper.Map<User>(dto);

            if (!string.IsNullOrEmpty(dto.Password))
                user.Password = _passwordHasher.HashPassword(user, dto.Password);

            await _userRepository.AddUserAsync(user);
            return _mapper.Map<UserReadDto>(user);
        }

        public async Task<UserReadDto> UpdateAsync(int id, UserUpdateDto dto)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            if (user == null)
                throw new KeyNotFoundException("User not found.");

            user.Name = dto.Name;
            user.LasName = dto.LasName;
            user.Email = dto.Email;

            if (!string.IsNullOrEmpty(dto.Password))
                user.Password = _passwordHasher.HashPassword(user, dto.Password);

            user.ProfilePictureUrl = dto.ProfilePictureUrl;

            await _userRepository.UpdateUserAsync(user);
            return _mapper.Map<UserReadDto>(user);
        }

        public Task<bool> EmailExistsAsync(string email)
        {
            return _userRepository.ExistsByEmailAsync(email);
        }

        public async Task<UserReadDto?> GetByEmailAsync(string email)
        {
            var user = await _userRepository.GetUserByEmailAsync(email);
            return user is null ? null : _mapper.Map<UserReadDto>(user);
        }

        public async Task<UserReadDto?> GetByGoogleIdAsync(string googleId)
        {
            var user = await _userRepository.GetUserByGoogleAuthIdAsync(googleId);
            return user is null ? null : _mapper.Map<UserReadDto>(user);
        }

        public async Task UpdateProfilePictureAsync(int id, string pictureUrl)
        {
            await _userRepository.UpdateProfilePictureAsync(id, pictureUrl);
        }

        public async Task ChangePasswordAsync(int id, string newPassword)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            if (user == null)
                throw new KeyNotFoundException("User not found.");

            user.Password = _passwordHasher.HashPassword(user, newPassword);
            await _userRepository.ChangePasswordAsync(id, user.Password);
        }
    }
}
