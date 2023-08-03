using System.Xml;

namespace SettingsPageLecture;

public partial class MainPage : ContentPage
{
	

	private void ReadSettings()
	{
		Color appBack;
		if (Preferences.Default.ContainsKey("AppBack"))
		{
			appBack = Color.FromHex(Preferences.Default.Get("AppBack", "#ffffff"));
		}
		else
		{
			appBack = Color.FromHex("#ffffff");
		}
		Application.Current.Resources["AppBack"] = appBack;
	}
	public MainPage()
	{
		InitializeComponent();
		//read back in
		ReadSettings();
	}

	
}

