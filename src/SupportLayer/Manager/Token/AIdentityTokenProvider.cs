using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupportLayer.Manager.Token
{
    public abstract class AIdentityTokenProvider
    {
        public abstract Task CreateToken(HttpContext context);
    }
}
