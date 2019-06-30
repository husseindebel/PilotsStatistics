using System;
using System.ComponentModel.DataAnnotations;

namespace Pilots.Statistics.Models
{
    public class Season
    {
        [Key]
        public int SeasonID { get; set; }
        public string Name { get; set; }
        public int Division { get; set; }

        public Competition Competition { get; set; }
        public int CompetitionID { get; set; }

    }
}
