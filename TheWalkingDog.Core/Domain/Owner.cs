using System;
using System.Collections.Generic;

namespace TheWalkingDog.Core.Domain
{
    public class Owner
    {
        public Guid Id { get; protected set; }

        public Guid UserId { get; protected set; }

        public IEnumerable<Dog> OwnedDogs { get; protected set; }
    }
}