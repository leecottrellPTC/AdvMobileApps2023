using SettingsLecture.Models;
using System.Runtime.CompilerServices;
using System.IO;
using System.Text.Json;

namespace SettingsLecture;

public partial class MainPage : ContentPage
{
	//int count = 0;

	public HelloClicker hc = new();
	private string _fileName = FileSystem.AppDataDirectory + "/HelloClicker.txt";
    private async void WriteToFile()
    {
		//async is because this can take time, we want the program to continue even if file system is slow
		//Testit.Text = _fileName;
		var writeData = JsonSerializer.Serialize(hc);	//write out one line of JSON
		File.WriteAllText(_fileName, writeData);
    }

	private async void ReadFile()
	{
        HelloClicker readHC = new();
		if (File.Exists(_fileName)== false){
			//no file
			return;
		}
		var rawData = File.ReadAllText(_fileName);
		readHC = JsonSerializer.Deserialize<HelloClicker>(rawData);
		hc.Total = readHC.Total;
		hc.Last = readHC.Current;
		hc.Current = 0;
        
		CounterBtn.Text = $"Clicked {hc.Total} times";
		CurrentClickLabel.Text = "0";
		LastClickLabel.Text = hc.Last.ToString();
    }

    public MainPage()
	{
		InitializeComponent();
		Color appBack;
		if (Preferences.Default.ContainsKey("AppBack"))
		{
			appBack = Color.FromHex(Preferences.Default.Get("AppBack", "#000000"));//need a default
		}
		else
		{
            appBack = Color.FromHex("#000000");//need a default
        }
		Application.Current.Resources["AppBack"] = appBack;

		ReadFile();
		

		
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{

		hc.Current++;
		hc.Total++;
   
        //count++;

		if (hc.Total == 1)
			CounterBtn.Text = $"Clicked {hc.Total} time";
		else
			CounterBtn.Text = $"Clicked {hc.Total} times";
		
		CurrentClickLabel.Text = hc.Current.ToString();


        SemanticScreenReader.Announce(CounterBtn.Text);
		WriteToFile();
	}

	
}

