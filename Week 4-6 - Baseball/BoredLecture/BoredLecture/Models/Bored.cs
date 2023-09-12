using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BoredLecture.Models
{
    public class Bored:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChangedEventArgs args = new PropertyChangedEventArgs(propertyName);
                PropertyChanged(this, args);
            }
        }

        //public string activity { get; set; }
        private string _activity;

        public string activity
        {
            get { return _activity; }
            set {
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

        public Bored()
        {
            _activity = "No activity, stilĺ bored 😒";
            
        }
    }
}
