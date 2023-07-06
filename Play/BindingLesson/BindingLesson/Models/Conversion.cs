using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingLesson.Models
{
    public class Conversion
    {
        public string Name { get; set; }
        public double Multiplier { get; set; }

        public Conversion(string name, double multiplier)
        {
            Name = name;
            Multiplier = multiplier;
        }

        public Conversion() { }
    }


}
