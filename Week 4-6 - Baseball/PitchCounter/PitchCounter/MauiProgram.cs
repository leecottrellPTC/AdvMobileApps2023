using PitchCounter.ViewModels;

namespace PitchCounter;

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
		string dbPath = System.IO.Path.Combine(FileSystem.AppDataDirectory, "pitcher.db3");
		builder.Services.AddSingleton<PitcherDatabase>(s => ActivatorUtilities.CreateInstance<PitcherDatabase>(s, dbPath));
		return builder.Build();
	}
}
