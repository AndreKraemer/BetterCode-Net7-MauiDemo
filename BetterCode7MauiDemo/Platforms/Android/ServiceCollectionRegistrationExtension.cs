using BetterCode7MauiDemo.Services;
using BetterCode7MauiDemo.Droid;

namespace BetterCode7MauiDemo;

public static class ServiceCollectionRegistrationExtension
{
    public static void RegisterPlatformServices(this IServiceCollection services)
    {
        services.AddTransient<IDeviceInformation, AndroidDeviceInformation>();
    }
}
