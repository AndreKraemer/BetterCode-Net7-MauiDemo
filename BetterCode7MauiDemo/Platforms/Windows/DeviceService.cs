namespace BetterCode7MauiDemo.Services;
public partial class DeviceService
{
    public partial string GetDeviceName()
    {
        var deviceInformation = new Windows.Security
            .ExchangeActiveSyncProvisioning.EasClientDeviceInformation();
        return deviceInformation.FriendlyName;
    }
}
