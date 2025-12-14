using App.Web.EndPoints.Products.Get;
using App.Web.Features.Products.Create;

namespace App.Web.Features.Products;

public static class ProductRegistrations
{
    public static WebApplication MapProductEndpoints(this WebApplication app)
    {
        app.MapDeleteProductEndpoints();
        app.MapGetProductsEndpoints();
        app.MapCreateProductEndpoints();

        return app;
    }
}
