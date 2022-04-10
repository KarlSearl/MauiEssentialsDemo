using Samples.View;

namespace MauiEssentials;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new HomePage());
	}


	public static void HandleAppActions(AppAction appAction)
	{
		App.Current.Dispatcher.Dispatch(async () =>
		{
			var page = appAction.Id switch
			{
				"battery_info" => new BatteryPage(),
				"app_info" => new AppInfoPage(),
				_ => default(Page)
			};

			if (page != null)
			{
				await Application.Current.MainPage.Navigation.PopToRootAsync();
				await Application.Current.MainPage.Navigation.PushAsync(page);
			}
		});
	}
}
