using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pilots.Statistics.Models
{
    public class Rounds
    {
        [Key]
        public int RoundId { get; set; }
        public string Label { get; set; }

        public ICollection<Match> Matches { get; set; }
    }
}
