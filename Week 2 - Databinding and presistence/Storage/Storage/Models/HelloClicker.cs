using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Models
{
    public class HelloClicker
    {
        public int Total { get; set; }
        public int Current { get; set; }
        public int Last { get; set; }
        public HelloClicker(int total, int current, int last)
        {
            Total = total;
            Current = current;
            Last = last;
        }
        public HelloClicker()
        {
            Total = 0;
            Current = 0;
            Last = 0;
        }
    }
}
