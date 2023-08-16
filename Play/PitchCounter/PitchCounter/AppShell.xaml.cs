namespace PitchCounter;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		//Data.DataBase Data = new();
		Routing.RegisterRoute("easteregg", typeof(Views.EasterEgg));
	}
}
