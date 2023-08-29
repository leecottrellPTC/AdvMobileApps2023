using PitchCounter.ViewModels;
namespace PitchCounter;

public partial class App : Application
{
	public static PitcherDatabase pitchDBase { get; private set; }
	public App(PitcherDatabase database)
	{
		InitializeComponent();

		MainPage = new AppShell();
		pitchDBase = database;
	}
}
