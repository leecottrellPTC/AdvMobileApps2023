namespace PitchCounter.Views;
using PitchCounter.Data;

[QueryProperty(nameof(PlayerIndex), "PlayerIndex")]
public partial class Player : ContentPage
{
	public Models.PlayerClass aPlayer;
    public DataBase data = new DataBase();
	//defines the array, yes it is repetitive and there are better ways to do this MVVM
	int playerIndex;	
	public int PlayerIndex
	{
		get => playerIndex;
		set
        {
			playerIndex = value;
			OnPropertyChanged();//only need for MVVM, leaving in for clairt later
			showPlayer();
        } 
	}

	Random rnd = new Random();
    public Player()
	{
		InitializeComponent();
		//showPlayer();
	}

	public void showPlayer()
	{
       // DisplayAlert("Player", playerIndex.ToString(), "OK");
        //playerIndex = (int)rnd.Next(4);
        aPlayer = data.PlayerRay[playerIndex];
		BallLabel.Text = aPlayer.Balls.ToString();
		StrikeLabel.Text = aPlayer.Strikes.ToString();
		TotalLabel.Text = aPlayer.Total.ToString();
		NameLabel.Text = aPlayer.Name.ToString();
	}

	protected async override void OnAppearing()
	{
		base.OnAppearing();
       // playerIndex = (int)rnd.Next(4);
		showPlayer();
    }
	
	public async void GoBack(object sender, EventArgs e)
	{
        //await Shell.Current.GoToAsync("//Data");
        await Shell.Current.GoToAsync("//..");
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("easteregg");
		//this is a global route, since it is the only one, no //
		//ignore this an an error
    }
}