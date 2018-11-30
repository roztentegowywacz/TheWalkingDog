using System;
using TheWalkingDog.Infrastructure.DTO;

namespace TheWalkingDog.Infrastructure.Services
{
    public interface IWalkerService
    {
        WalkerDto Get(Guid userId);
    }
}