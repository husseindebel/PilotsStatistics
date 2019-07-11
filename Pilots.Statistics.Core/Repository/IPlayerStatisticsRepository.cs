using Pilots.Statistics.Core.Models;

namespace Pilots.Statistics.Core.Repository
{
    public interface IPlayerStatisticsRepository
    {
        PlayerStatistic GetPlayerStatisticByPlayerId(int playerId);
        void InsertPlayerStatistic(PlayerStatistic playerStatistic);
        void UpdatePlayerStatistic(PlayerStatistic playerStatistic);
    }
}
