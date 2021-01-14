using System;

namespace ServicesLayers.Domain.Entities
{
    public class Person
    {
        public Person (Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set }
    }
}