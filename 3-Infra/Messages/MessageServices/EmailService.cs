using System;

namespace ServicesLayers.Infra.Messages.MessageServices
{
    public class EmailService
    {
        public EmailService (string to, string subject, string body)
        {
            To = to;
            Subject = subject;
            Body = body;
        }

        public string To { get; private set; }
        public string Subject { get; private set }
        public string Body { get; private set }
        public bool Sucess { get; private set }

        public void Send()
        {
            // Send e-mail
            Sucess = true;
        }
    }
}