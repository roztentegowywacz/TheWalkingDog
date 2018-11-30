using System;
using TheWalkingDog.Core.Domain;
using TheWalkingDog.Core.Repositories;
using TheWalkingDog.Infrastructure.DTO;

namespace TheWalkingDog.Infrastructure.Services
{
    public class UserSevice : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserSevice(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserDto Get(string email)
        {
            var user = _userRepository.Get(email);

            return new UserDto
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                FullName = user.FullName
            };
        }

        public void Register(string email, string username, string password)
        {
            var user = _userRepository.Get(email);
            if (user != null)
            {
                throw new Exception($"User with email: {email} already exists.");
            }

            var salt = Guid.NewGuid().ToString("N");
            user = new User(email, username, password, salt);
            _userRepository.Add(user);
        }
    }
}