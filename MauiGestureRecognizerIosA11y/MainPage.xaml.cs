namespace MauiGestureRecognizerIosA11y;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object? sender, EventArgs eventArgs)
	{
		count++;

		string text;
		if (count == 1)
			text = $"Clicked {count} time";
		else
			text = $"Clicked {count} times";

		CounterLabel.Text = text;
		CounterLabel2.Text = text;

		SemanticScreenReader.Announce(text);
	}
}
