using BetterCode7MauiDemo.Services;
using BetterCode7MauiDemo.ViewModels;
using BetterCode7MauiDemo.Views;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace BetterCode7MauiDemo;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiMaps()
            .UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("Font Awesome 6 Free-Solid-900.otf", "FA-6-Solid-900");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<IDataService, FileDataService>();
        builder.Services.AddTransient<MainPage, MainPageViewModel>();
        builder.Services.AddTransient<SessionsPage, SessionsPageViewModel>();
        builder.Services.AddTransientWithShellRoute<SessionDetailPage, SessionDetailPageViewModel>(nameof(SessionDetailPage));

        return builder.Build();
	}
}
