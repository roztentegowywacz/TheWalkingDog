using System;

namespace TheWalkingDog.Core.Domain
{
    public class Dog
    {
        public Guid Id { get; protected set; }

        public Guid OwnerId { get; protected set; }

        public string Name { get; protected set; }

        public Node Adress { get; protected set; }


        protected Dog()
        {
        }

        public Dog(string name)
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