using System;
using System.ComponentModel.DataAnnotations;

namespace Pilots.Statistics.Models
{
    public class MatchStatistics
    {
        [Key]
        public int Id { get; set; }
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }

        public Match Match { get; set; }
        public int MatchId { get; set; }
    }
}
