using System;
using System.ComponentModel.DataAnnotations;

namespace Pilots.Statistics.Models
{
    public class Match
    {
        [Key]
        public int MatchId { get; set; }
        public DateTimeOffset Date { get; set; }

        public Rounds Round { get; set; }
        public int RoundId { get; set; }

        public Season Season { get; set; }
        public int SeasonId { get; set; }
    }
}
