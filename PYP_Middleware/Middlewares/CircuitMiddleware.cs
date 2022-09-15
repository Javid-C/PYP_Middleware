namespace PYP_Middleware.Middlewares
{
    public class CircuitMiddleware
    {
        private readonly RequestDelegate _next;

        public CircuitMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Items["IE"] as bool? == true)
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden;
            }
            else
            {
                await _next.Invoke(context);
            }
        }
    }
}
