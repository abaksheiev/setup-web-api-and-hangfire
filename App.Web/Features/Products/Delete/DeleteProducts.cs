using App.MessageBus.Contracts;
using App.MessageBus.Models;
using App.Web.Data;
using Hangfire;

namespace App.Web.EndPoints.Products.Get;

public static class DeleteProductEndPoint
{
    public static IEndpointRouteBuilder MapDeleteProductEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app
        .MapGroup("/api/")
        .WithTags("Products");


        group.MapDelete("/product/{id}", DeleteProduct);


        return app;
    }


    private static IResult DeleteProduct(Guid id, IMessageHandler messageHandler)
    {

        var product = MockProducts.Instance.Products.SingleOrDefault(p => p.Id == id); ;

        if (product == null)
            return Results.NotFound();

        BackgroundJob.Enqueue(
                () => messageHandler.SendMessage(ProductMessage.Delete(product.Id, product.Name, product.Description)
            )
        );

        return Results.Ok(true);

    }
}
