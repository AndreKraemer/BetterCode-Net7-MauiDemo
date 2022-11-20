using BetterCode7MauiDemo.Services;
namespace BetterCode7MauiDemo.iOS;
public class IosDeviceInformation: IDeviceInformation
{
    public string GetName()
    {
        return UIKit.UIDevice.CurrentDevice.Name;
    }
}
