using Pilots.Statistics.Core.Models;
using System;

namespace Pilots.Statistics.Core.Repository
{
    public interface ICompetitionsRepository
    {
        Competition GetCompetitionByDate(DateTime date);
        void InsertCompetition(Competition competition);
    }
}
