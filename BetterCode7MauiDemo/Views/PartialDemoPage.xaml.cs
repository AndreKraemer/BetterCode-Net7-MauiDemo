using BetterCode7MauiDemo.Services;

namespace BetterCode7MauiDemo.Views;

public partial class PartialDemoPage : ContentPage
{
	public PartialDemoPage()
	{
		InitializeComponent();
		var deviceService = new DeviceService();
		DeviceInfoLabel.Text = deviceService.GetDeviceName();
	}
}