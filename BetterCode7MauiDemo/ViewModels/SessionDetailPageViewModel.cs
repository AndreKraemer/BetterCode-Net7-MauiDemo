using BetterCode7MauiDemo.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BetterCode7MauiDemo.ViewModels;

[INotifyPropertyChanged]
[QueryProperty(nameof(Session), nameof(Session))]
public partial class SessionDetailPageViewModel
{

    [ObservableProperty]
    private Session _session;

    [RelayCommand]
    private void OpenTwitter()
    {
        Browser.OpenAsync(Session.Speaker.Twitter);
    }

}
