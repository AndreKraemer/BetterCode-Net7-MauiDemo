using BetterCode7MauiDemo.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BetterCode7MauiDemo.ViewModels;

[INotifyPropertyChanged]
public partial class MainPageViewModel
{
    [RelayCommand]
    private async Task NavigateToSessions()
    {
       await Shell.Current.GoToAsync($"///{nameof(SessionsPage)}");
    }
}
