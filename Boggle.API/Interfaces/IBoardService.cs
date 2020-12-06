using Boggle.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Boggle.API.Interfaces
{
    public interface IBoardService
    {
        Task<IEnumerable<Dice>> CreateBoardAsync();
    }
}
