using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.ComponentModel;

namespace PitchCounter.Models
{
    public class PlayerClass:INotifyPropertyChanged
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

        private int _balls;

		public int Balls
		{
			get { return _balls; }
			set { _balls = value;
                Total = _balls + _strikes;
                OnPropertyChanged("Balls");
                }
		}

		private int _strikes;

		public int Strikes
		{
			get { return _strikes; }
			set { _strikes = value;
                Total = _balls + _strikes;
                OnPropertyChanged("Strikes");
            }
		}

		private int _total;

		public int Total
		{
			get { return _total; }
			set { _total = value;
                OnPropertyChanged("Total");
            }
		}

		private string _name;

        

        public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

        public PlayerClass(int balls, int strikes, int total, string name)
        {
            _balls = balls;
            _strikes = strikes;
            _total = total;
            _name = name;
        }

        public PlayerClass(int balls, int strikes, int total)
        {
            _balls = balls;
            _strikes = strikes;
            _total = total;
        }

        public PlayerClass()
		{
            _balls = 0;
            _strikes = 0;
            _total = 0;
            _name = "No Name";
        }
    }
}
