using System.Net.Mail;
using SOLID.DIP.Solution.Interfaces;

namespace SOLID.DIP.Solution;
public class EmailService : IEmailService
{
  public void Send(string to, string emailFor, string subject, string message)
  {
    var mail = new MailMessage(to, emailFor);
    var client = new SmtpClient
    {
      Port = 25,
      DeliveryMethod = SmtpDeliveryMethod.Network,
      UseDefaultCredentials = false,
      Host = "smtp.google.com"
    };

    mail.Subject = subject;
    mail.Body = message;
    client.Send(mail);
  }
}