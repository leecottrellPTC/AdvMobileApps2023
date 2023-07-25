using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBindLecture_WeightConvert.Models;

namespace DataBindLecture_WeightConvert.Data
{
    public class DataClass
    {
        public Conversion[] DataConvRay = new Conversion[4];
        public DataClass() {
            DataConvRay[0] = new Conversion("Kg to Lb", 2.205);
            DataConvRay[1] = new Conversion("G to Oz", .0335);
            DataConvRay[2] = new Conversion("Oz to G", 20.349);
            DataConvRay[3] = new Conversion("Lb to Kg", .4536);
        }
    }
}
