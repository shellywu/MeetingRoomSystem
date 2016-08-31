using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SupportLayer.Manager.Token
{
    interface IUserIdentityCreator
    {
        Task<ClaimsIdentity> CreateIdentity(string userName,string pwd);
    }
}
