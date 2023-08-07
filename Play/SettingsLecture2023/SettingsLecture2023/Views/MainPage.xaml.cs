namespace SettingsLecture2023;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
        Color appBack;
        if (Preferences.Default.ContainsKey("AppBack"))
        {
            appBack = Color.FromHex(Preferences.Default.Get("AppBack", "#000000"));//set a defaul of #000000
        }
        else
        {
            appBack = Color.FromHex("#000000");

        }
        Application.Current.Resources["AppBack"] = appBack;
    }

	
}

