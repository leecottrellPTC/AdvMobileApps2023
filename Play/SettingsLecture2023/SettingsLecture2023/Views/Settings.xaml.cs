
namespace SettingsLecture2023.Views;

public partial class Settings : ContentPage
{
    ResourceDictionary ColorResource = Application.Current.Resources.MergedDictionaries.FirstOrDefault() as ResourceDictionary;
    //https://learn.microsoft.com/en-us/answers/questions/1189601/access-color-inside-resources-colors
    //set a dictionary to read the XAML file
    public Settings()
	{
		InitializeComponent();
	}
	public void ChangeSettings(object sender, EventArgs e)
	{
		//use one function for the three objects
		if (sender.Equals(Back1))
		{
            //Application.Current.Resources["AppBack"] = Application.Current.Resources["Back1"];//cannot see Back1??
            Application.Current.Resources["AppBack"] = ColorResource["Back1"];
            //Use Application to set the global value, colorresource to read the file
		}
        else if (sender.Equals(Back2))
        {
            Application.Current.Resources["AppBack"] = ColorResource["Back2"];
        }
        else if (sender.Equals(Back3))
        {
            Application.Current.Resources["AppBack"] = ColorResource["Back3"];
        }
        else
        {
            Application.Current.Resources["AppBack"] = ColorResource["Back1"];
        }
        Color appBack;
        appBack = (Color)Application.Current.Resources["AppBack"];
        DisplayAlert("Color", appBack.ToHex().ToString(), "OK");
        Preferences.Default.Set("AppBack", appBack.ToHex().ToString());
    }
}