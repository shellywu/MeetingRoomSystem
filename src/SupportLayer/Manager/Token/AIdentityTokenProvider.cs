using Microsoft.AspNetCore.Http;
using SupportLayer.CoreModel;
using SupportLayer.Manager.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SupportLayer.Manager.Token
{
    public abstract class AIdentityTokenProvider : IIdentityTokenCreator, IUserIdentityCreator
    {
        public ATokenParameters TokenParamters { get; set; }
        public ASignManager SignManager { get; set; }
        public AIdentityTokenProvider()
        {

        }
       
        public abstract Task CreateToken(HttpContext context);
        public abstract Task<ClaimsIdentity> CreateIdentityByPassword(string userName, string passwd);
    }
}
