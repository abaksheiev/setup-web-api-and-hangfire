using App.Web.Features.Products;
using Hangfire;

namespace App.Web.Infrastructure;

public static class WebApplicationExtenssions
{
    public static void WebApplicationRegister(this WebApplication app)
    {
        app
            .MapEndpoints()
            .SwaggerRegistration()
            .HangfireRegistration();
    }

    private static WebApplication SwaggerRegistration(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        return app;
    }

    private static WebApplication MapEndpoints(this WebApplication app)
    {
        app.MapProductEndpoints();

        return app;
    }

    private static WebApplication HangfireRegistration(this WebApplication app)
    {
        app.UseHangfireDashboard("/hangfire");

        return app;
    }
}
