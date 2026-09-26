using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Scoped services
        // services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}