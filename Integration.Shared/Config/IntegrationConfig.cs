using Integration.Shared.Exceptions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Integration.Shared.Config;
public static class IntegrationConfig
{
    public static IServiceCollection AddIntegration(this IServiceCollection services)
    {
        services.AddExceptionHandler<GlobalExceptionHandler>();
        services.AddProblemDetails();

        return services;
    }

    public static void AddIntegration(this WebApplication app)
    {
        app.UseExceptionHandler();
    }
}
