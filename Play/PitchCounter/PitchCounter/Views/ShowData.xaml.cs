namespace PitchCounter.Views;
using PitchCounter.Models;
using PitchCounter.Data;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

public partial class Data : ContentPage
{
	public DataBase data = new();//defines the array
	public Data()
	{
		InitializeComponent();
        //binding failed WTF
        for(int x=0; x < data.PlayerRay.Count(); x++)
        {
            PlayerPicker.Items.Add(data.PlayerRay[x].ToString());
        }

       // PlayerPicker.SetBinding(Picker.ItemsSourceProperty, "data.PlayerRay");
       // PlayerPicker.ItemDisplayBinding = new Binding("Name");
        //ListSizeLabel.Text = data.PlayerRay.Count().ToString() + "Player Ray";
        //for(int x=0; x <data.PlayerRay.Count(); x++)
        //{
        //	PlayerList.Add(data.PlayerRay[x]);
        //DisplayAlert("HI", "HH", "HI");
        //	Debug.WriteLine(data.PlayerRay[x].ToString());
        //}
        //DisplayAlert("List", data.PlayerRay.Count().ToString(), "OK");
    }

    public async void ShowPlayer(object sender, EventArgs e)
    {
        //DisplayAlert("Pitcher", PlayerPicker.SelectedIndex.ToString(), "OK");
        var pageParams = new Dictionary<string, object>()
        {
            {"PlayerIndex", PlayerPicker.SelectedIndex }
        };
        await Shell.Current.GoToAsync("//Player", pageParams);
        //why
    }
}