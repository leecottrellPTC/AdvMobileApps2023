using PitchCounter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitchCounter.Data
{
    public class DataBase
    {
        public PlayerClass[] PlayerRay = new PlayerClass[4];
        public DataBase() {
            //balls strikes total name
            PlayerRay[0] = new PlayerClass(5, 6, 11, "David Bednar");
            PlayerRay[1] = new PlayerClass(7, 9, 16, "Colin Holderman");
            PlayerRay[2] = new PlayerClass(11, 22, 33, "Rich Hill");
            PlayerRay[3] = new PlayerClass(6, 9, 15, "Mitch Keller");
        }

    }
}
