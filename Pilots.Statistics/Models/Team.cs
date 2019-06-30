using System;
using System.Collections.Generic;

namespace Pilots.Statistics.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string Colour { get; set; }

        public ICollection<Player> Players { get; set; }
        public ICollection<Match> Matches { get; set; }
    }
}
