using MSLEarn6___REST.Models;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MSLEarn6___REST;

public partial class MainPage : ContentPage
{
	HttpClient client;
	string URL = "https://www.dnd5eapi.co/api/monsters/";
	Critter theCritter;

    public MainPage()
	{
		InitializeComponent();
		client = new HttpClient();
	}

	private void OnSearchButton(object sender, EventArgs e)
	{

		URL += "adult-black-dragon";
		//URL += nameEntry.Text.ToString().ToLower().Trim();
        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, URL);
		request.Content = JsonContent.Create<Critter>(theCritter);		
        //https://www.dnd5eapi.co/api/monsters/adult-black-dragon

		HttpResponseMessage	response = client.SendAsync(request).Result;
		//jsonLabel.Text = response.Content.ReadAsStringAsync().Result;
		string json = response.Content.ReadAsStringAsync().Result;
		jsonLabel.Text = json;
		//theCritter = JsonSerializer.Deserialize<Critter>(json);
		//jsonLabel.Text = URL;
		//nameLabel.Text = theCritter.name;
		//string monsterURI = "https://www.dnd5eapi.co" + theCritter.image.ToString();

      //  jsonLabel.Text = monsterURI;
	///	critterImage.Source = monsterURI;

    }
}

