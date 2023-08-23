using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BoredAPIPlay.Models
{
    public class Bored : INotifyPropertyChanged
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
        private string _activity;
        public string Activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
                OnPropertyChanged("activity");
            }
        }
        public string type { get; set; }
        public int participants { get; set; }
        public double price { get; set; }
        public string link { get; set; }
        public string key { get; set; }
        public double accessibility { get; set; }

        public Bored(string activity, string type, int participants, float price, string link, string key, float accessibility)
        {
            this._activity = activity;
            this.type = type;
            this.participants = participants;
            this.price = price;
            this.link = link;
            this.key = key;
            this.accessibility = accessibility;
        }

        public Bored()
        {
            this._activity = "No Activity";
            this.type = "Education";
            this.participants = 1;
            this.price = .1;
            this.link = "www.google.com";
            this.key = "key";
            this.accessibility = .3;
        }


    }
}
