using System;
using System.Collections.Generic;

namespace TheWalkingDog.Core.Domain
{
    public class Walk
    {
        public Guid Id { get; protected set; }

        public Route Route { get; protected set; }

        public IEnumerable<DogNode> DogNodes { get; protected set; }
    }
}