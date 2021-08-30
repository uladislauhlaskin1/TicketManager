using System.Threading.Tasks;

using MailKit.Net.Smtp;
using MimeKit;

namespace TicketManager.Models.Emails
{
    public class EmailSender
    {
        public Ticket Ticket { get; private set; }
        public string EmailReceiver { get; private set; }

        public EmailSender(Ticket ticket, string emailReceiver)
        {
            Ticket = ticket;
            EmailReceiver = emailReceiver;
        }

        //try yandex instead
        public async Task SendEmailAsync()
        {
            string email = EmailReceiver;
            string subject = "Ticked Reservation";
            string message = $"We want to remind that you reserved a ticket. The even will be at {Ticket.Concert.Location.Name}. " +
                $"The date of the event is {Ticket.Concert.Date.ToString("dd.MM.yyyy HH.mm")} and your ticket number is {Ticket.Concert}";
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Ticket Manager", "uladislau.hlaskin@gmail.com"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 587, false);
                await client.AuthenticateAsync("uladislau.hlaskin@gmail.com", "password");
                await client.SendAsync(emailMessage);
                await client.DisconnectAsync(true);
            }
        }
    }
}
