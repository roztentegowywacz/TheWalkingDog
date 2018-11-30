using System;
using System.Collections.Generic;

namespace TheWalkingDog.Core.Domain
{
    public class Route
    {
        public Guid Id { get; protected set; }    

        public Node StartNode { get; protected set; }

        public Node FinishNode { get; protected set; }

        public IEnumerable<Park> Parks { get; set; }
    }
}