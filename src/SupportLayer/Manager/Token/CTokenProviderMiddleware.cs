using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using SupportLayer.CoreModel;
using SupportLayer.Manager.Account;
using Microsoft.Extensions.OptionsModel;
using SupportLayer.Manager.Token.Abstraction;

namespace SupportLayer.Manager.Token
{
    public class CTokenProviderMiddleware : AbstractMiddleware
    {
        private AIdentityTokenProvider _tokenProvider;
        public CTokenProviderMiddleware(RequestDelegate next,AIdentityTokenProvider options):base(next,options.TokenParamters)
        {
            _tokenProvider = options;
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
            try
            {

                return _tokenProvider.CreateToken(context);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500;
                return context.Response.WriteAsync("internalError");
            }
        }
    }
}
