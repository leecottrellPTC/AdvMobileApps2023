using System.Runtime.CompilerServices;

namespace SettingsLecture2023;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new AppShell();
	}
	protected override void OnStart()
	{
			base.OnStart();
	}

    protected override void OnSleep()
    {
        base.OnSleep();
    }

    protected override void OnResume()
    {
        base.OnResume();
    }
   
}
