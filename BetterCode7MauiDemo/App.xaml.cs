namespace BetterCode7MauiDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
    }
    protected override Window CreateWindow(IActivationState activationState)
    {
        var window = base.CreateWindow(activationState);

        const int newWidth = 700;
        const int newHeight = 800;


        // center the window
        window.X = 300;
        window.Y = 100;

        // resize
        window.Width = newWidth;
        window.Height = newHeight;

        return window;
    }
}
