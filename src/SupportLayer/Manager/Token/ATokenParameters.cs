using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace SupportLayer.Manager.Token
{
    public abstract class ATokenParameters
    {
        public abstract string Path { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public TimeSpan Expiration { get; set; } = TimeSpan.FromMinutes(5);
        public SigningCredentials SigningCredentials { get; set; }
    }
}
