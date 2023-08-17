namespace PitchCounter.Views;

public partial class EasterEgg : ContentPage
{
	public EasterEgg()
	{
		InitializeComponent();
	}

    private async void GoBack(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..");
		//works because we are navigating back to the global route
    }
}