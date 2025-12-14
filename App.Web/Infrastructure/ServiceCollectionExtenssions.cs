using App.MessageBus.Contracts;
using App.MessageBus.Handlers;
using Hangfire;
using Hangfire.MemoryStorage;

namespace App.MessageBus;

public static class ServiceCollectionExtenssions
{
    public static void ServiceCollectionRegister(this IServiceCollection services)
    {
        services
            .SwaggerRegistration()
            .MessageBusRegistration()
            .HangfireRegistration();
    }

    private static IServiceCollection SwaggerRegistration(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }

    private static IServiceCollection MessageBusRegistration(this IServiceCollection services)
    {
        services.AddSingleton<IMessageHandler, MessageHandler>();
        return services;
    }

    private static IServiceCollection HangfireRegistration(this IServiceCollection services) 
    {
        services.AddHangfire(config =>
        {
            config.UseMemoryStorage(); // Only for tests
        });

        services.AddHangfireServer(); // Run in backroung

        return services;
    }
}
