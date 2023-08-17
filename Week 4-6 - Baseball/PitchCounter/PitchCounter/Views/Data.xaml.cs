namespace PitchCounter.Views;
using PitchCounter.Data;

public partial class Data : ContentPage
{
	public DataBase TheData = new();
	public Data()
	{
		InitializeComponent();
		for(int x=0; x< TheData.PlayerRay.Length; x++)
		{
			PlayerPicker.Items.Add(TheData.PlayerRay[x].Name);
		}
	}

    private async void ShowThePlayer(object sender, EventArgs e)
    {
		//asynchronous
		//when you do not know how long the code will take

		var pageParams = new Dictionary<string, object>()
		{
			//list all fields you want to send
			{"PlayerIndex", PlayerPicker.SelectedIndex }
		};

        //await Shell.Current.GoToAsync("//Player");
        await Shell.Current.GoToAsync("//Player", pageParams);
        //navigate to Player --// means lookat current level and down
    }
}