using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PitchCounter.Models
{
    public class PlayerClass
    {
		private int _balls;

		public int Balls
		{
			get { return _balls; }
			set { _balls = value; }
		}

		private int _strikes;

		public int Strikes
		{
			get { return _strikes; }
			set { _strikes = value; }
		}

		private int _total;

		public int Total
		{
			get { return _total; }
			set { _total = value; }
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

		public PlayerClass()
		{
            _balls = 0;
            _strikes = 0;
            _total = 0;
            _name = "No Name";
        }
    }
}
