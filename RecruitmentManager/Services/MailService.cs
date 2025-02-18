using SendGrid.Helpers.Mail;
using SendGrid;

namespace RecruitmentManager.Services;

public class MailService
{
    public async Task SendEmail(EmailAddress from, string subject, EmailAddress to, string plainTextContent, string htmlContent)
    {
        string apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
        var client = new SendGridClient(apiKey);
       
        var message = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
        var response = await client.SendEmailAsync(message);
    }
}
