using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebEmailSendGrid.SendEmail
{
    public class Sendgrid
    {
       public  async Task Execute()
        {
            var apiKey = Environment.GetEnvironmentVariable("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");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("mcordovat@soenperu.com", "marlo");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("mcordovat@soenperu.com", "raphael");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}