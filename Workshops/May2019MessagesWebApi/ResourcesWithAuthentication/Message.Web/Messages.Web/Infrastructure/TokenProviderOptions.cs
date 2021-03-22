using Microsoft.IdentityModel.Tokens;
using System;

namespace Messages.Web.Infrastructure
{
    public class TokenProviderOptions
    {
        public string Path { get; set; } = "/webapi/users/login";

        public string Issuer { get; set; }

        public string Audience { get; set; }

        public TimeSpan Expiration { get; set; } = TimeSpan.FromDays(15);

        public SigningCredentials SignCredentials { get; set; }
    }
}
