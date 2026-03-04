using Microsoft.Extensions.Logging;
using MauiGestureRecognizerIosA11y.ViewModels;
using MauiGestureRecognizerIosA11y.Views;

namespace MauiGestureRecognizerIosA11y;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		// Register ViewModels
		builder.Services.AddSingleton<MainViewModel>();
		
		// Register Views
		builder.Services.AddSingleton<MainView>();

		return builder.Build();
	}
}
