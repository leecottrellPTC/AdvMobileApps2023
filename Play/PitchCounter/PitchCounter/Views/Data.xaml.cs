namespace PitchCounter.Views;
using PitchCounter.Models;
using PitchCounter.Data;
using System.Security.Cryptography.X509Certificates;

public partial class Data : ContentPage
{
	//I have two things named player, Models.Player specifies
	public DataBase data = new DataBase();//defines the array
	public List<Models.Player> playerList { get; set; } = new List<Models.Player>();
	public Data()
	{
		InitializeComponent();
		foreach(Models.Player p in data.PlayerRay)
		{	
			playerList.Add(p);
		}
	}
}