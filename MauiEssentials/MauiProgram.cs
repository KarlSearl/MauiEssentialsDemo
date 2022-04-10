using MauiEssentials.ViewModels;

namespace MauiEssentials;

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
			});

		builder.Services.AddSingleton<Dashboard>();
		builder.Services.AddSingleton<DashboardVM>();
		return builder.Build();
	}
}
