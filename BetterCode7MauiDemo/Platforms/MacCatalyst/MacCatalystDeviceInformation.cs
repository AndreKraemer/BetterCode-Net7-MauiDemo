using BetterCode7MauiDemo.Services;
namespace BetterCode7MauiDemo.MacCatalyst;

public class MacCatalystDeviceInformation : IDeviceInformation
{
    public string GetName()
    {
        return UIKit.UIDevice.CurrentDevice.Name;
    }
}
