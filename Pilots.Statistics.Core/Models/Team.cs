using System;
using System.Collections.Generic;

namespace Pilots.Statistics.Core.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Colour { get; set; }

        public ICollection<Player> Players { get; set; }
        public ICollection<Match> Matches { get; set; }
    }
}
