using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        /*
        services.AddScoped<IFindeksService, FakeFindeksServiceAdapter>();
        services.AddScoped<IPOSService, FakePOSServiceAdapter>();
        services.AddScoped<IImageService, CloudinaryImageServiceAdapter>();
        */
        return services;
    }
}