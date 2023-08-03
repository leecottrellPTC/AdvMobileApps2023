using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugProject.Models
{
    public class Team
    {
        public string teamName { get; set; }
        public string cityName { get; set; }
        public string leagueName { get; set; }

        public Team()
        {

        }

        public Team(string teamName, string cityName, string leagueName)
        {
            this.teamName = teamName;
            this.cityName = cityName;
            this.leagueName = leagueName;
        }
    }
}
