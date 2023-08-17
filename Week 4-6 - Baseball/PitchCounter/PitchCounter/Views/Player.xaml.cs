namespace PitchCounter.Views;


using PitchCounter.Data;
using PitchCounter.Models;

[QueryProperty(nameof(PlayerIndex), "PlayerIndex")]
public partial class Player : ContentPage
{
	public PlayerClass aPlayer;
	public DataBase TheData = new();

	public int playerIndex = 0;

	public int PlayerIndex
	{
		get => playerIndex;
		set
		{
			playerIndex = value;
			OnPropertyChanged();
			ShowPlayer();
		}
	}
	public Player()
	{
		InitializeComponent();
	}

	public void ShowPlayer()
	{
		aPlayer = TheData.PlayerRay[playerIndex];
		BallLabel.Text = aPlayer.Balls.ToString();
		StrikeLabel.Text = aPlayer.Strikes.ToString();
		TotalLabel.Text = aPlayer.Total.ToString();
		PlayerNameLabel.Text = aPlayer.Name;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		ShowPlayer();
    }

	protected override void OnDisappearing() {  
		//screen leaves vision
		base.OnDisappearing(); 
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
		//come in from another page
		//runs before appearing
        base.OnNavigatedTo(args);
    }

    protected override void OnNavigatingFrom(NavigatingFromEventArgs args)
    {
		//when leaving the page
        base.OnNavigatingFrom(args);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("easteregg");
		//no // bcause it is global, built in App.xaml.cs constructor
    }
}