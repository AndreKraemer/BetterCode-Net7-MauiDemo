using BetterCode7MauiDemo.Services;

namespace BetterCode7MauiDemo.Views;

public partial class DependencyInjectionDemoPage : ContentPage
{
    public DependencyInjectionDemoPage(IDeviceInformation deviceInfo)
    {
        InitializeComponent();
        DeviceInfoLabel.Text = deviceInfo.GetName();
    }
}