using System;
using System.Collections.Generic;
using System.Linq;
using TheWalkingDog.Core.Domain;
using TheWalkingDog.Core.Repositories;

namespace TheWalkingDog.Infrastructure.Repositories
{
    public class InMemoryWalkerRepository : IWalkerRepository
    {
        private static ISet<Walker> _walkers = new HashSet<Walker>();

        public void Add(Walker walker)
        {
            _walkers.Add(walker);
        }

        public Walker Get(Guid userId)
            => _walkers.Single(x => x.UserId == userId);

        public IEnumerable<Walker> GetAll()
            => _walkers;

        public void Update(Walker walker)
        {
            throw new NotImplementedException();
        }
    }
}