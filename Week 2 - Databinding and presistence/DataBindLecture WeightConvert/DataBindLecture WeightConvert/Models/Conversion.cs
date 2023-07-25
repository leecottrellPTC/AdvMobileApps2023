using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindLecture_WeightConvert.Models
{
    public class Conversion
    {
        public String Name { get; set; }
        public double Multiplier { get; set; }

        public Conversion() { }

        public Conversion(string name, double multiplier)
        {
            Name = name;
            Multiplier = multiplier;
        }
    }
}
