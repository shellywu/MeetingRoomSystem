using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Newtonsoft.Json;
using SupportLayer.CoreModel;
using SupportLayer.Manager.Account;
using System.Security.Principal;
using SupportLayer.Manager.Token.Abstraction;

namespace SupportLayer.Manager.Token
{
    public class IdentityTokenProvider : AIdentityTokenProvider
    {
        public IdentityTokenProvider()
        {

        }
        public override async Task<ClaimsIdentity> CreateIdentityByPassword(string username, string password)
        {
            var r = await SignManager.UserLogin(username, password);
            if (r != null)
            {
                return new ClaimsIdentity(new GenericIdentity(r.NickName, "Token"), new Claim[] { });
            }
            return null;
        }

        public override async Task CreateToken(HttpContext context)
        {
            var username = context.Request.Form["username"];
            var password = context.Request.Form["password"];

            var identity = await CreateIdentityByPassword(username, password);
            if (identity == null)
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsync("Invalid username or password");
                return;
            }
            var now = DateTime.UtcNow;
            var claims = new Claim[] {
                new Claim(JwtRegisteredClaimNames.Sub,username),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat,ToUnixEpochDate(now).ToString(),ClaimValueTypes.Integer64)
            };

            var jwt = new JwtSecurityToken(
                issuer: TokenParamters.Issuer,
                audience: TokenParamters.Audience,
                claims: claims,
                notBefore: now,
                expires: now.Add(TokenParamters.Expiration),
                signingCredentials: TokenParamters.SigningCredentials
                );
            try
            {

                var encodeJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
                var response = new
                {
                    access_token = encodeJwt,
                    expires_in = (int)TokenParamters.Expiration.TotalSeconds
                };

                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(JsonConvert.SerializeObject(response, new JsonSerializerSettings { Formatting = Formatting.Indented }));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private long ToUnixEpochDate(DateTime utcNow)
        {
            return (long)Math.Round((utcNow.ToUniversalTime() - new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero)).TotalSeconds);
        }
    }
}
