using Boggle.API.Interfaces;
using Boggle.API.Models;
using Boggle.API.Services;
using Xunit;

namespace Boggle.Tests
{
    public class BoardTests
    {
        IBoardService boardService = new BoardService();

        [Fact(DisplayName = "CreateBoard Check Board Size")]
        public void CreateBoardCheckBoardSize()
        {
            Dice[] dices = boardService.CreateBoard();
            Assert.NotNull(dices);
            Assert.True(dices.Length == 16);
        }
    }
}
