using System.Net.Mail;

namespace AuthenticatorTest2
{
    public class Emailer
    {
        public void sendEmail(string email, string subject, string body)
        {
            MailMessage mail = new MailMessage("[email]", email,subject, body);
            mail.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();

            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Host = "[smtp-server]";
            client.EnableSsl = true;
            client.Credentials = new System.Net.NetworkCredential("[email]", "[password]");

            client.Send(mail);
        }
    }
}