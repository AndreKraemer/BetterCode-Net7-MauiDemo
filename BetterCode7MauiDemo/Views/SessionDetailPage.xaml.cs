using BetterCode7MauiDemo.ViewModels;

namespace BetterCode7MauiDemo.Views;

public partial class SessionDetailPage : ContentPage
{
    public SessionDetailPage(SessionDetailPageViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }
}