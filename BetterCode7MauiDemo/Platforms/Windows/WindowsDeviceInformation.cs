using BetterCode7MauiDemo.Services;
using BetterCode7MauiDemo.WinUI;


namespace BetterCode7MauiDemo.WinUI;
public class WindowsDeviceInformation : IDeviceInformation
{
    public string GetName()
    {
        var deviceInformation = new Windows.Security
            .ExchangeActiveSyncProvisioning.EasClientDeviceInformation();
        return deviceInformation.FriendlyName;
    }
}