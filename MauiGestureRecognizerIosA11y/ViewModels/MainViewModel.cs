using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiGestureRecognizerIosA11y.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty] private string _title = "Welcome to .NET MAUI!";
    [ObservableProperty] private string _message = "Click the button to update the counter";
    [ObservableProperty] private int _counter;

    [RelayCommand]
    private void IncrementCounter()
    {
        Counter++;
        Message = Counter switch
        {
            1 => "Clicked 1 time",
            _ => $"Clicked {Counter} times"
        };
    }
}

