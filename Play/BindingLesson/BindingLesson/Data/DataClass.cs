using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BindingLesson.Models;

namespace BindingLesson.Data
{
    public class DataClass
    {
        public Conversion[] DataConvRay = new Conversion[4];

        public DataClass()
        {
            //this will get better when we get to MVVM
            DataConvRay[0] = new Conversion("Kg to Lb", 2.205);
            DataConvRay[1] = new Conversion("G to Oz", .0353);
            DataConvRay[2] = new Conversion("Oz to g", 28.349);
            DataConvRay[3] = new Conversion("Lb to Kg", .4536);

        }
     
    }
}
