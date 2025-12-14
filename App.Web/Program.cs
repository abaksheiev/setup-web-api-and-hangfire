using App.MessageBus;
using App.Web.Infrastructure;

namespace App.Web;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.ServiceCollectionRegister();
       
        var app = builder.Build();

        app.WebApplicationRegister();

        app.Run();
    }
}
