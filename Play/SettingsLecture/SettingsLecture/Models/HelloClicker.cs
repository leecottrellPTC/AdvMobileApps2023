using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingsLecture.Models
{
    public class HelloClicker
    {
        public int Total { get; set; }      //total clicks
        public int Last { get; set; }       //clicks from last time
        public int Current { get; set; }    //clicks this session

        public HelloClicker(int total, int last, int current)
        {
            Total = total;
            Last = last;
            Current = current;
        }

        public HelloClicker() {
            //these values are for testing. We will set to 0 later
            Total = 0;
            Last = 0;
            Current = 0;
        }

        
    }
}
