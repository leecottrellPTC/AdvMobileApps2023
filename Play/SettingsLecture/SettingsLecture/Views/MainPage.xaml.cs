namespace SettingsLecture;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		Color appBack;
		if (Preferences.Default.ContainsKey("AppBack"))
		{
			appBack = Color.FromHex(Preferences.Default.Get("AppBack", "#000000"));//need a default
		}
		else
		{
            appBack = Color.FromHex("#000000");//need a default
        }
		Application.Current.Resources["AppBack"] = appBack;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

