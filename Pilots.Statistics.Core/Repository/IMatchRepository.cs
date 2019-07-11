using System.Text.RegularExpressions;

namespace Pilots.Statistics.Core.Repository
{
    public interface IMatchRepository
    {
        void InsertMatch(Match match);
        void DeleteMatch(Match match);
        void UpdateMatch(Match match);
        void GetMatchById(Match match);
    }
}
