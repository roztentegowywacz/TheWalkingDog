using TheWalkingDog.Infrastructure.DTO;

namespace TheWalkingDog.Infrastructure.Services
{
    public interface IUserService
    {
        UserDto Get(string email);

        void Register(string email, string username, string password);
    }
}