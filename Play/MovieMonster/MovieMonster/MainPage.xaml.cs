namespace MovieMonster;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	void OnMovieChanged(object sender, EventArgs e)
	{
		var moviePick = (Picker)sender;
		//moviePick.sel
		if(moviePick.SelectedItem.ToString() == "Alien")
		{
            posterImage.Source = "alienPoster.jpg";
            monsterImage.Source = "alienMonster.jpg";
        }
        else if (moviePick.SelectedItem.ToString() == "Friday the 13th")
        {
            posterImage.Source = "fridayPoster.jpg";
            monsterImage.Source = "fridayMonster.jpg";
        }
        else if (moviePick.SelectedItem.ToString() == "Halloween")
        {
            posterImage.Source = "halloweenPoster.jpg";
            monsterImage.Source = "halloweenMonster.jpg";
        }



    }
}

