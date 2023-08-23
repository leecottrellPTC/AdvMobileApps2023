using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoredAPIPlay.Models;
using System.ComponentModel;

namespace BoredAPIPlay.ViewModels
{
    public class BoredViewModel:INotifyPropertyChanged
    {
		private Bored _boredValues;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChangedEventArgs args = new PropertyChangedEventArgs(propertyName);

                PropertyChanged(this, args);
            }
        }

        public Bored BoredValues
		{
			get { return _boredValues; }
			set { _boredValues = value; }
		}
		public BoredViewModel()
		{
			_boredValues = new Bored();	
		}

	}
}
