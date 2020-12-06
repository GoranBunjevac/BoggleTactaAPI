using Boggle.API.Interfaces;
using Boggle.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Boggle.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        private IBoardService _boardService;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="boardService"></param>
        public BoardController(IBoardService boardService)
        {
            _boardService = boardService;
        }

        /// <summary>
        /// Get board dices.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _boardService.CreateBoardAsync();
            return Ok(result);
        }
    }
}
