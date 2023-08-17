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
}