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
        public string activity
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
        private string _type;
        public string type {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
                OnPropertyChanged("type");
            }
         }
        private int _participants;
        public int participants
        {
            get
            {
                return _participants;
            }
            set
            {
                _participants = value;
                OnPropertyChanged("participants");
            } 
        }
        private double _price;
        public double price 
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                OnPropertyChanged("price");
            }
        }
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
            this._activity = "No Activity Described";
            this.type = "Education";
            this.participants = 1;
            this.price = .1;
            this.link = "www.google.com";
            this.key = "key";
            this.accessibility = .3;
        }


    }
}
