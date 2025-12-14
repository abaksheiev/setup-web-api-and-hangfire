using App.Web.Data;

namespace App.Web.EndPoints.Products.Get;

public static  class GetProductsEndPoint
{
    public static IEndpointRouteBuilder MapGetProductsEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app
        .MapGroup("/api/")
        .WithTags("Products");


        group.MapGet("/products", GetProducts);


        return app;
    }


    private static IResult GetProducts()
    {
        var products = MockProducts.Instance.Products;

        return Results.Ok(products);
    }
}
