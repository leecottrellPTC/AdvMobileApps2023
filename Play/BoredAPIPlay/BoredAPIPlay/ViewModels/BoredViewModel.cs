using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoredAPIPlay.Models;
using System.ComponentModel;
using System.Text.Json;

namespace BoredAPIPlay.ViewModels
{
    public class BoredViewModel:INotifyPropertyChanged
    {
        HttpClient _httpClient;
        JsonSerializerOptions _serializerOptions;   //adds System.Text.Json

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChangedEventArgs args = new PropertyChangedEventArgs(propertyName);

                PropertyChanged(this, args);
            }
        }
        private Bored _boredValues;
        public Bored BoredValues
        {
            get { return _boredValues; }
            set { _boredValues = value; }
        }

        public BoredViewModel()
        {
            _boredValues = new Bored();
            ConsumeRestCommand = new Command(ConsumeRest);
            _httpClient = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
            };
        }

        public Command ConsumeRestCommand { get; private set; }
        public async void ConsumeRest()
        {
            //need to bind the DisplayAlert to a page
            //App.Current.MainPage.DisplayAlert("REST", "Not implemented", "OK");
            Bored values = new Bored();
            Uri uri = new Uri("https://www.boredapi.com/api/activity/");
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    //await App.Current.MainPage.DisplayAlert("REST", content, "It worked");
                    values = JsonSerializer.Deserialize<Bored>(content, _serializerOptions);
                    //a single value is returned, not a list
                    _boredValues.activity = values.activity;
                    _boredValues.price = values.price;
                    _boredValues.participants = values.participants;
                    _boredValues.type = values.type;
                    
                }
            }
            catch(Exception e)
            {
                await App.Current.MainPage.DisplayAlert("REST", e.ToString(), "Bummer");
            }
        }

    }
}
