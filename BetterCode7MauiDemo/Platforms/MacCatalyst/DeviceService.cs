namespace BetterCode7MauiDemo.Services;
public partial class DeviceService
{
    public partial string GetDeviceName()
    {
        return UIKit.UIDevice.CurrentDevice.Name;
    }
}
