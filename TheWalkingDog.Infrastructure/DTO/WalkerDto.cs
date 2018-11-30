using System;
using System.Collections.Generic;
using TheWalkingDog.Core.Domain;

namespace TheWalkingDog.Infrastructure.DTO
{
    public class WalkerDto
    {
        public Guid UserId { get; set; }

        public IEnumerable<Route> Routes { get; set; }  

        public IEnumerable<Walk> Walks { get; set; } 
    }
}