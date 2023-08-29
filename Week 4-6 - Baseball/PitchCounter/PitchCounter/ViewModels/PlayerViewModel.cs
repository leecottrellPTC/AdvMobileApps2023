using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PitchCounter.Models;
using System.ComponentModel;
using PitchCounter.ViewModels;

namespace PitchCounter.ViewModels
{
    public class PlayerViewModel : INotifyPropertyChanged
    {
        public Command AddBallCommand { get; set; }
        public Command AddStrikeCommand { get; set; }
        public Command ResetCommand { get; set; }
        public Command NewPitcherCommand { get; set; }

        public async void NewPitcher()
        {
            bool saveIt = await App.Current.MainPage.DisplayAlert("New Pitcher?",
                    "Save and clear pitcher?", "Yes", "No");
            if (saveIt)
            {
                //will write to database here
                App.pitchDBase.InsertPitcher(_thePitcher);
                _thePitcher.Name = null;
                _thePitcher.Balls = 0;
                _thePitcher.Strikes = 0;
                _thePitcher.GameDate = DateTime.Now;
            }
        }

        public void Reset()
        {
            _thePitcher.Balls = 0;
            _thePitcher.Strikes = 0;
            _thePitcher.Total = 0;
        }

        public PlayerViewModel()
        {
            //link the public Command to the logic function
            AddBallCommand = new Command(AddBall);
            AddStrikeCommand = new Command(AddStrike);
           // ResetCommand = new Command(Reset);
            NewPitcherCommand = new Command(NewPitcher);
            _thePitcher = new PlayerClass();
        }
        public void AddBall()
        {
            _thePitcher.Balls++;
        }

        public void AddStrike() 
        {
            _thePitcher.Strikes++;
        }
        private PlayerClass _thePitcher;

        public PlayerClass ThePitcher
        {
            get { return _thePitcher; }
            set { _thePitcher = value; }
        }

        //default Constructor
   

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
               // PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

                PropertyChangedEventArgs args = new PropertyChangedEventArgs(propertyName);

                PropertyChanged(this, args);
            }
        }
    }
}
