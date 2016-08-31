using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace SupportLayer.Manager.Token
{
    public class IdentityTokenProvider : AIdentityTokenProvider
    {
        public override Task<ClaimsIdentity> CreateIdentity(string userName,string pwd)
        {
            return Task.FromResult<ClaimsIdentity>(null);
        }

        public override async Task CreateToken(HttpContext context)
        {
            var username = context.Request.Form["username"];
            var password = context.Request.Form["password"];
            var identity = await CreateIdentity(username,password);
        }
    }
}
