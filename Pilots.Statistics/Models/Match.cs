using System;
namespace Pilots.Statistics.Models
{
    public class Match
    {
        public int MatchID { get; set; }
        public DateTimeOffset Date { get; set; }

        public Rounds Round { get; set; }
    }
}
