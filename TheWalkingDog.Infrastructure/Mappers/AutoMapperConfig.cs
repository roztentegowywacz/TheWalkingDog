using AutoMapper;
using TheWalkingDog.Core.Domain;
using TheWalkingDog.Infrastructure.DTO;

namespace TheWalkingDog.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDto>();
                cfg.CreateMap<Walker, WalkerDto>();
            })
            .CreateMapper();
    }
}