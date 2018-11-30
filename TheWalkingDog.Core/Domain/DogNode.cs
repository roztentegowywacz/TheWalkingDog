using System;

namespace TheWalkingDog.Core.Domain
{
    public class DogNode
    {
        public Node Node { get; protected set; }

        public Dog Dog { get; protected set; }
    }
}