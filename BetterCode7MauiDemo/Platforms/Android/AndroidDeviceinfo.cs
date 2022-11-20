using BetterCode7MauiDemo.Services;
namespace BetterCode7MauiDemo.Droid;
public class AndroidDeviceInformation : IDeviceInformation
{
    public  string GetName()
    {
        return Android.OS.Build.Device;
    }
}
