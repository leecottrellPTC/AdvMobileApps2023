
namespace SettingsLecture.Views;

public partial class Settings : ContentPage
{
	public Settings()
	{
		InitializeComponent();
        
    }
	private void ColorChange(object sender, EventArgs e)
	{
		if (sender.Equals(Back1))
		{
			Application.Current.Resources["AppBack"] = Application.Current.Resources["Back1"];
		}
        else if (sender.Equals(Back2))
        {
            Application.Current.Resources["AppBack"] = Application.Current.Resources["Back2"];
        }
		else if(sender.Equals(Back3))
        {
            Application.Current.Resources["AppBack"] = Application.Current.Resources["Back3"];
        }
        else{
            Application.Current.Resources["AppBack"] = Application.Current.Resources["Back1"];
        }

        Color appBack;
        appBack = (Color)Application.Current.Resources["AppBack"];
        Preferences.Default.Set("AppBack", appBack.ToHex().ToString());
    }
}