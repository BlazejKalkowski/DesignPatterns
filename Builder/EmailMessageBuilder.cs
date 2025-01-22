using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class EmailMessageBuilder
    {
        private readonly EmailSender _email = new EmailSender();


        public EmailMessageBuilder AddSender(string sender)
        {
            _email.Sender = sender;
            return this;
        }

        public EmailMessageBuilder AddRecipient(string recipient)
        {
            _email.Recipient = recipient;
            return this;
        }

        public EmailMessageBuilder AddBody(string body)
        {
            _email.Body = body;
            return this;
        }

        public EmailMessageBuilder AddSubject(string subject)
        {
            _email.Subject = subject;
            return this;
        }

        public EmailSender Build()
        {
            return _email;
        }
    }
}
