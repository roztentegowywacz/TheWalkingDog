using System;
using AutoMapper;
using TheWalkingDog.Core.Domain;
using TheWalkingDog.Core.Repositories;
using TheWalkingDog.Infrastructure.DTO;

namespace TheWalkingDog.Infrastructure.Services
{
    public class UserSevice : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserSevice(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public UserDto Get(string email)
        {
            var user = _userRepository.Get(email);

            return _mapper.Map<User, UserDto>(user);
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