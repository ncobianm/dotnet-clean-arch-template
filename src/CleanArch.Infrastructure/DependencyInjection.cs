using CleanArch.Application.Common.Interfaces.Services;
using CleanArch.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager builderConfiguration)
    {
        // Options
        // services.Configure<JwtSettings>(builderConfiguration.GetSection(JwtSettings.SectionName));
        
        // Singleton services
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        // Scoped services
        // services.AddScoped<IUserRepository, UserRepository>();
        
        return services;
    }
}