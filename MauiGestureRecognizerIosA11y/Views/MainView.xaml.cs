using MauiGestureRecognizerIosA11y.ViewModels;

namespace MauiGestureRecognizerIosA11y.Views;

public partial class MainView : ContentPage
{
    public MainView(MainViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}

