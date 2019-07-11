using Pilots.Statistics.Core.Models;

namespace Pilots.Statistics.DAL.Repository
{
    public interface IRoundsRepository
    {
        Rounds GetRoundById(int id);
        Rounds GetRoundByLabel(string label);
    }
}
