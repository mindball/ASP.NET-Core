namespace CameraBazaar.Web.Extensions
{
    //using Microsoft.AspNetCore.Identity.UI.Services;
    using CameraBazaar.Web.Services;
    using System.Text.Encodings.Web;
    using System.Threading.Tasks;

    public static class EmailSenderExtensions
    {
        public static Task SendEmailConfirmationAsync(this IEmailSender emailSender, string email, string link)
        {
            return emailSender.SendEmailAsync(email, "Confirm your email",
                $"Please confirm your account by clicking this link: <a href='{HtmlEncoder.Default.Encode(link)}'>link</a>");
        }
    }
}
