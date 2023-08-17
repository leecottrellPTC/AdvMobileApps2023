namespace PitchCounter.Views;


using PitchCounter.Data;
using PitchCounter.Models;


public partial class Player : ContentPage
{
	public PlayerClass aPlayer;
	public DataBase TheData = new();

	public int playerIndex = 0;
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
}