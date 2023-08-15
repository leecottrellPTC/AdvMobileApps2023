using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PitchCounter.Models;

namespace PitchCounter.Data
{
    public class DataBase
    {
        public Player[] PlayerRay = new Player[4]; 

        public DataBase()
        {
            PlayerRay[0] = new Player(5, 6, 11, "Dave Bednar");
            PlayerRay[1] = new Player(11, 15, 26, "Mitch Keller");
            PlayerRay[2] = new Player(7, 15, 22, "Colin Holderman");
            PlayerRay[3] = new Player(12, 9, 21, "Rich Hill");
        }

    }
}
