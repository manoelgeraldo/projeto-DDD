using System;

namespace ServiceLayers.Domain.Services
{
    public class PersonService
    {
        public PersonService (Person person)
        {
            Person = person;
        }

        public Person person { get; private set; }
        public bool Sucess { get; private set; }

        public void Save()
        {
            // Save person Logic
            Sucess = true;
        }
    }
}