using PYP_Middleware.Extentions;
using System.Diagnostics;

namespace PYP_Middleware.Middlewares
{
    public class ContentMiddleware
    {

        private readonly RequestDelegate _next;
        private readonly UptimeService _time;

        public ContentMiddleware(RequestDelegate next,UptimeService time)
        {
            _next = next;
            _time = time;
        }

        public async Task Invoke(HttpContext context)
        {
            await _next.Invoke(context);
            if (context.Request.Path.Value?.ToLower() == "/change")
            {
                await context.Response.WriteAsync($" (Change) Middlewarein ishleme muddeti {_time.Milliseconds}");
            }
            else
            {
                await context.Response.WriteAsync($"Middlewarein ishleme muddeti {_time.Milliseconds}");
            }
            //response
        }
    }
}
