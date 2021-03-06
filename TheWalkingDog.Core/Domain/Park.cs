using System;

namespace TheWalkingDog.Core.Domain
{
    public class Park
    {
        public Guid Id { get; protected set; }

        public string Name { get; protected set; }


        private Park()
        {
        }

        public Park(string name)
        {
            SetName(name);
        }

        private void SetName(string name)
        {
            if (Name == name)
            {
                return;
            }

            Name = name;
        }
    }
}