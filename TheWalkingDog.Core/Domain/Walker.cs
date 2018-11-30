using System;
using System.Collections.Generic;

namespace TheWalkingDog.Core.Domain
{
    public class Walker
    {
        public Guid Id { get; protected set; }

        public Guid UserId { get; protected set; }

        public IEnumerable<Route> Routes { get; protected set; }  

        public IEnumerable<Walk> Walks { get; protected set; }  
    }
}