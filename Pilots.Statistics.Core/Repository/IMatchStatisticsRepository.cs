using Pilots.Statistics.Core.Models;
using System.Collections.Generic;

namespace Pilots.Statistics.Core.Repository
{
    public interface IMatchStatisticsRepository
    {
        IEnumerable<MatchStatistics> GetAllMatchStatistics();
        MatchStatistics GetMatchStatisticsByMatchId(int matchId);
        void InsertMatchStatistic(MatchStatistics matchStatistics);
        void UpdateMatchStatistic(MatchStatistics matchStatistics);
    }
}
