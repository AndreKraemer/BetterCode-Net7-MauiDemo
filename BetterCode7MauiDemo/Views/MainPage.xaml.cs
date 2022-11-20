using BetterCode7MauiDemo.ViewModels;

namespace BetterCode7MauiDemo.Views;

public partial class MainPage : ContentPage
{


	public MainPage(MainPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}


}

