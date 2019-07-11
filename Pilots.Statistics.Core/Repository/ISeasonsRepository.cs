using Pilots.Statistics.Core.Models;

namespace Pilots.Statistics.Core.Repository
{
    public interface ISeasonsRepository
    {
        void InsertSeason(Season season);
        Season GetSeasonById(int seasonId);
    }
}
