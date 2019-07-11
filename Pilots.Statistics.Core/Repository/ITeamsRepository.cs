using Pilots.Statistics.Core.Models;
using System.Collections.Generic;

namespace Pilots.Statistics.Core.Repository
{
    public interface ITeamsRepository
    {
        IEnumerable<Team> GetTeams();
        Team GetTeamById(int teamId);
        void InsertTeam(Team team);
        void DeleteTeam(Team team);
        void UpdateTeam(Team team);
        void Save();
    }
}
