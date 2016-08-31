using Microsoft.AspNetCore.Http;
using SupportLayer.CoreModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SupportLayer.Manager.Token
{
    interface IUserIdentityCreator
    {
        Task<ClaimsIdentity> CreateIdentityByPassword(string userName,string passwd);
    }
}
