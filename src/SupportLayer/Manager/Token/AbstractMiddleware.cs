using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace SupportLayer.Manager.Token.Abstraction
{
    public abstract class AbstractMiddleware
    {
        public RequestDelegate Next { get; private set; }
        public ATokenParameters Parameters { get;private set; }
        public AbstractMiddleware(RequestDelegate next, ATokenParameters parameters)
        {
            Next = next;
            Parameters = parameters;
        }
        public abstract Task Invoke(HttpContext context);
    }
}
