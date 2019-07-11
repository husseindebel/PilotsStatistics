using System;
using System.ComponentModel.DataAnnotations;

namespace Pilots.Statistics.Core.Models
{
    public class PlayerStatistic
    {
        [Key]
        public int Id { get; set; }
        public int FieldGoalsAttempted { get; set; }
        public int FieldGoalsMade { get; set; }
        public int ThreePointsAttempted { get; set; }
        public int ThreePointsMade { get; set; }
        public int FreeThrowsAttempted { get; set; }
        public int FreeThrowsMade { get; set; }
        public int Assists { get; set; }
        public int Rebounds { get; set; }
        public int Steals { get; set; }
        public int Blocks { get; set; }
        public int Turnovers { get; set; }
        public int FoulsGiven { get; set; }
        public int FoulsDrawn { get; set; }

        public Player Player { get; set; }
        public int PlayerId { get; set; }

        public Match Match { get; set; }
        public int MatchId { get; set; }
    }
}
