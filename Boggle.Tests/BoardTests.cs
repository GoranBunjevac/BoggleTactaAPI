using Boggle.API.Interfaces;
using Boggle.API.Models;
using Boggle.API.Services;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Boggle.Tests
{
    public class BoardTests
    {
        IBoardService boardService = new BoardService();

        [Fact(DisplayName = "CreateBoard Check Board Size")]
        public void CreateBoardCheckBoardSize()
        {
            var dices = boardService.CreateBoardAsync().Result.ToList();
            Assert.NotNull(dices);
            Assert.True(dices.Count == 16);
        }
    }
}
