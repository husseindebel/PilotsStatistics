using System;
namespace Pilots.Statistics.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int JerseyNumber { get; set; }

        public Team Team { get; set; }
        public int TeamId { get; set; }
    }
}
