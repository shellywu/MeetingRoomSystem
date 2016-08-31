using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.Manager.Token
{
    interface IIdentityTokenCreator
    {
        Task CreateToken(HttpContext context);
    }
}
