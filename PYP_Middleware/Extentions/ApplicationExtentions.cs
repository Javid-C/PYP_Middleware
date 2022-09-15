using PYP_Middleware.Middlewares;

namespace PYP_Middleware.Extentions
{
    public static class ApplicationExtentions
    {
        public static IApplicationBuilder UseContent(this IApplicationBuilder app)
        {
            app.UseMiddleware<RequestEditingMiddleware>();
            app.UseMiddleware<CircuitMiddleware>();
            app.UseMiddleware<ResponseEditingMiddleware>();
            return app.UseMiddleware<ContentMiddleware>();
        }
    }
}
