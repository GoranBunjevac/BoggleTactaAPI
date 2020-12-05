using Boggle.API.Models;

namespace Boggle.API.Interfaces
{
    public interface IBoardService
    {
        Dice[] CreateBoard();
    }
}
