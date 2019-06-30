using System;
using System.Collections.Generic;

namespace Pilots.Statistics.Models
{
    public class Competition
    {
        public int CompetitionID { get; set; }
        public DateTimeOffset StartDate { get; set; }

        public ICollection<Season> Seasons { get; set; }
    }
}
