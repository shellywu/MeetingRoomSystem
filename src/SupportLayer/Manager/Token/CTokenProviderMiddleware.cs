using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SupportLayer.Manager.Token
{
    public class CTokenProviderMiddleware : AbstractMiddleware
    {
        private AIdentityTokenProvider _tokenProvider;
        public CTokenProviderMiddleware(RequestDelegate next, ATokenParameters parameters,AIdentityTokenProvider identifyTokenProvider):base(next,parameters)
        {
            _tokenProvider = identifyTokenProvider;
        }

        public override Task Invoke(HttpContext context)
        {
            if (!context.Request.Path.Equals(Parameters.Path, StringComparison.Ordinal)) {
                return Next(context);
            }

            if (!context.Request.Method.Equals("POST") || !context.Request.HasFormContentType) {
                context.Response.StatusCode = 400;
                return context.Response.WriteAsync("Bad request");
            }

            return _tokenProvider.CreateToken(context);
        }
    }
}
