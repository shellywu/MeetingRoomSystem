using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SupportLayer.Manager.Token;
using SupportLayer.Manager.Account;
using SupportLayer.CoreModel;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Newtonsoft.Json;
using SupportLayer.CoreModel.Abstraction;

namespace MRServerAPI
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            if (env.IsEnvironment("Development"))
            {
                // This will push telemetry data through Application Insights pipeline faster, allowing you to view results immediately.
                builder.AddApplicationInsightsSettings(developerMode: true);
            }

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddApplicationInsightsTelemetry(Configuration);

            var wl = new List<string>();
            foreach (var item in Configuration.GetSection("WhiteList").GetChildren())
            {
                wl.Add(item.Value);
            }

            ////容许跨域请求
            //services.AddCors(options =>
            //{
            //    options.AddPolicy("WhiteList", builder =>
            //    {
            //        builder.WithOrigins(wl.ToArray())
            //        .WithMethods("GET", "POST", "PUT", "DELETE");
            //    });
            //});

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseApplicationInsightsRequestTelemetry();

            app.UseApplicationInsightsExceptionTelemetry();

            var securityKey = Configuration.GetValue<string>("SecretConfig:TokenConfiguration:SecurityKey");
            var aduience = Configuration.GetValue<string>("SecretConfig:TokenConfiguration:Audience");
            var issuer = Configuration.GetValue<string>("SecretConfig:TokenConfiguration:wxl");

            var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(securityKey));

            var options = new IdentityTokenProvider()
            {
                SignManager = new CSignManager(new AppUser()),
                TokenParamters = new CTokenParameters()
                {
                    Audience = aduience,
                    Issuer = issuer,
                    SigningCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256)
                }
            };
            app.UseMiddleware<CTokenProviderMiddleware>(new object[] { options });

            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = signingKey,

                ValidateIssuer = true,
                ValidIssuer = issuer,

                ValidateAudience = true,
                ValidAudience = aduience,

                // Validate the token expiry
                ValidateLifetime = true,

                // If you want to allow a certain amount of clock drift, set that here:
                ClockSkew = TimeSpan.Zero
            };

            app.UseJwtBearerAuthentication(new JwtBearerOptions
            {
                AutomaticAuthenticate = true,
                AutomaticChallenge = true,
                TokenValidationParameters = tokenValidationParameters
            });
            //app.UseCors("WhiteList");
            app.UseMvc();
        }
    }
}
