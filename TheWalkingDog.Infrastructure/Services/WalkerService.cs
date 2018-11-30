using System;
using TheWalkingDog.Core.Repositories;
using TheWalkingDog.Infrastructure.DTO;

namespace TheWalkingDog.Infrastructure.Services
{
    public class WalkerService : IWalkerService
    {
        private readonly IWalkerRepository _walkerRepository;

        public WalkerService(IWalkerRepository walkerRepository)
        {
            _walkerRepository = walkerRepository;
        }

        public WalkerDto Get(Guid userId)
        {
            var walker = _walkerRepository.Get(userId);

            return new WalkerDto();
        }
    }
}