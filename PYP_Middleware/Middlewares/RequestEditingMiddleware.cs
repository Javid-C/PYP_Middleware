namespace PYP_Middleware.Middlewares
{
    public class RequestEditingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestEditingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            context.Items["IE"] = context.Request.Headers["User-Agent"].Any(value => value.ToLower().Contains("trident"));
            await _next.Invoke(context);
        }
    }
}
