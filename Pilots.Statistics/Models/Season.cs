using System;
using System.ComponentModel.DataAnnotations;

namespace Pilots.Statistics.Models
{
    public class Season
    {
        [Key]
        public int SeasonId { get; set; }
        public string Name { get; set; }
        public int Division { get; set; }

        public Competition Competition { get; set; }
        public int CompetitionId { get; set; }

    }
}
