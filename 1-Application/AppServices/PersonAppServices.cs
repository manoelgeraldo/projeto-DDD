using System;
using ServicesLayers.Domain.Entities;
using ServicesLayers.Domain.Service;
using ServicesLayers.Infra.Messages.MessageServices;

namespace ServicesLayers.Application.AppServices
{
    public class PersonAppService
    {
        private readonly Person _person;
        public PersonAppService(string name)
        {
            _person = new Person(Guid.NewGuid(), name);
        }

        public void Save()
        {
            var personServiceSave = new PersonAppService(_person);
            personServiceSave.Save();

            if (personServiceSave.Success)
            {
                var emailService = new EmailService("test@mail.com", "Confirm", "Register saved.");
                emailService.Send();
            }
        }
    }
}