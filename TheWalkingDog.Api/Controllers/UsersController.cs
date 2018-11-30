using Microsoft.AspNetCore.Mvc;
using TheWalkingDog.Infrastructure.DTO;
using TheWalkingDog.Infrastructure.Services;

namespace TheWalkingDog.Api.Controllers
{
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpGet("{email}")]
        public UserDto Get(string email)
            => _userService.Get(email);
    }
}