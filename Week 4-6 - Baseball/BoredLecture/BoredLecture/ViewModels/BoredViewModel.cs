using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using BoredLecture.Models;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace BoredLecture.ViewModels
{
    public class BoredViewModel : INotifyPropertyChanged
    {
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
        }

        public Command ConsumeRestCommand { get; private set; }
        public async void ConsumeRest()
        {
            HttpClient client = new HttpClient();
            Bored values = new Bored();//hold onto results
            Uri uri = new Uri("https://www.boredapi.com/api/activity/");
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    values = JsonSerializer.Deserialize<Bored>(content);
                    _boredValues.activity = values.activity;
                }

            }
            catch(Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("REST Error", ex.ToString(), "Bummer");
            }
            //App.Current.MainPage.DisplayAlert("REST", "Not implemented", "Way Cool");
        }


    }
}
