using Pilots.Statistics.Core.Models;
using System.Collections.Generic;

namespace Pilots.Statistics.Core.Repository
{
    public interface IPlayersRepository
    {
        IEnumerable<Player> GetPlayers();
        Player GetPlayerById(int playerId);
        Player GetPlayerByName(int playerName);
        Player GetPlayerByNumber(int playerNumber);
        void InsertPlayer(Player player);
        void DeletePlayer(Player player);
        void UpdatePlayer(Player player);
        void Save();
    }
}
