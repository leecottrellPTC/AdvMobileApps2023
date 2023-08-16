namespace PitchCounter.Views;

public partial class EasterEgg : ContentPage
{
	public EasterEgg()
	{
		InitializeComponent();
	}

    public async void GoBack(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}