using BetterCode7MauiDemo.Droid;

namespace BetterCode7MauiDemo;

public static  class DependencyServiceRegistration
{
    public static void RegisterPlatformDependencies()
    {
        DependencyService.Register<AndroidDeviceInformation>();
    }
}
