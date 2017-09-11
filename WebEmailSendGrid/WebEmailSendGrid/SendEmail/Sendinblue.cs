using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace WebEmailSendGrid.SendEmail
{
    public class Sendinblue
    {
        public void Send() {
            string cfromPassword = "";
            string cfromAddress = "";
            
            cfromAddress = "mcordovat @soenperu.com";
            cfromPassword = "FOJzmBNhwjsWaPZL";
            

            var fromAddress = new MailAddress(cfromAddress, "Contacto Perfect Smile");
            var toAddress = new MailAddress("marloncordova@outlook.com", "To Name");

            const string subject = "Demo - Perfect Smile";



            var smtp = new SmtpClient
            {
                Host = "smtp-relay.sendinblue.com", 
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                // UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, cfromPassword)
            };

            string body = string.Format("Formatoo correoooo");

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                IsBodyHtml = true,
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}