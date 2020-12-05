using Boggle.API.Models;
using System.Collections.Generic;

namespace Boggle.API.Interfaces
{
    public interface IScoreService
    {
        int CalculateSingleScore(List<string> words);

        List<Player> CalculateMultiplayerScore(List<Player> players);
    }
}
