using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SupportLayer.Manager.Token
{
    public abstract class AIdentityTokenProvider:IIdentityTokenCreator,IUserIdentityCreator
    {
        public abstract Task<ClaimsIdentity> CreateIdentity(string userName,string pwd);

        public abstract  Task CreateToken(HttpContext context);
    }
}
