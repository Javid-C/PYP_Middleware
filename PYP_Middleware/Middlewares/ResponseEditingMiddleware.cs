namespace PYP_Middleware.Middlewares
{
    public class ResponseEditingMiddleware
    {
        private readonly RequestDelegate _next;

        public ResponseEditingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            //request
            await _next.Invoke(context);
            if(context.Response.StatusCode == StatusCodes.Status403Forbidden)
            {
                await context.Response.WriteAsync("Internet explorer desteklenmir");
            }else if (context.Response.StatusCode == StatusCodes.Status404NotFound)
            {
                await context.Response.WriteAsync("sehife ishlemir");
            }
        }
    }
}
