namespace PitchCounter;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("easteregg", typeof(Views.EasterEgg));
	}
}
