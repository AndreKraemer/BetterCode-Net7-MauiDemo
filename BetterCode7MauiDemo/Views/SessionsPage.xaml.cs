using BetterCode7MauiDemo.ViewModels;

namespace BetterCode7MauiDemo.Views;

public partial class SessionsPage : ContentPage
{
    private readonly SessionsPageViewModel _viewModel;
    public SessionsPage(SessionsPageViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = _viewModel = viewModel;
    }

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        await _viewModel.Initialize();
        base.OnNavigatedTo(args);
    }
}