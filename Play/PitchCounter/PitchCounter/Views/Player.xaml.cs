namespace PitchCounter.Views;
using PitchCounter.Data;

public partial class Player : ContentPage
{
	public Models.Player aPlayer;
    public DataBase data = new DataBase();
	//defines the array, yes it is repetitive and there are better ways to do this MVVM
	public int playerIndex = 0;
	Random rnd = new Random();
    public Player()
	{
		InitializeComponent();
		showPlayer();
	}

	public void showPlayer()
	{
        playerIndex = (int)rnd.Next(4);
        aPlayer = data.PlayerRay[playerIndex];
		BallLabel.Text = aPlayer.Balls.ToString();
        StrikeLabel.Text = aPlayer.Strikes.ToString();
        TotalLabel.Text = aPlayer.Total.ToString();
        NameLabel.Text = aPlayer.Name.ToString();
    }

	protected async override void OnAppearing()
	{
		base.OnAppearing();
        playerIndex = (int)rnd.Next(4);
		showPlayer();
    }
	
	

}