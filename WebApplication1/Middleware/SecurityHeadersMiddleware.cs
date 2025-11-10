using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SecureUserPortal.Middleware
{
    public class SecurityHeadersMiddleware
    {
        private readonly RequestDelegate _next;

        public SecurityHeadersMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Protect against clickjacking, XSS, MIME sniffing
            context.Response.Headers.Add("X-Frame-Options", "DENY");
            context.Response.Headers.Add("X-Content-Type-Options", "nosniff");
            context.Response.Headers.Add("X-XSS-Protection", "1; mode=block");

            await _next(context);
        }
    }
}
