using App.MessageBus.Contracts;
using App.MessageBus.Models;
using Hangfire;

namespace App.Web.Features.Products.Create;

public static class CreateProductEndPoint
{
    public static IEndpointRouteBuilder MapCreateProductEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app
        .MapGroup("/api/")
        .WithTags("Products");


        group.MapPost("/product/", CreateProducts);

        return app;
    }


    private static IResult CreateProducts(string name, string description, IMessageHandler messageHandler)
    {
        if (string.IsNullOrEmpty(name) || 
            string.IsNullOrEmpty(description))
        {
            return Results.NotFound();
        }

        BackgroundJob.Enqueue(
                () => messageHandler.SendMessage(ProductMessage.Create(name, description)
            )
        );

        return Results.Ok(true);
    }
}
