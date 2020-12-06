using Boggle.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Boggle.API.Interfaces
{
    public interface IScoreService
    {
        Task<int> CalculateSingleScoreAsync(List<string> words);

        Task<List<Player>> CalculateMultiPlayerScoreAsync(List<Player> players);
    }
}
