using Boggle.API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Boggle.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ScoreController : ControllerBase
    {
        private IScoreService _scoreService;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="scoreService"></param>
        public ScoreController(IScoreService scoreService)
        {
            _scoreService = scoreService;
        }

        /// <summary>
        /// Get Scores.
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<int> Get([FromQuery]List<string> words)
        {
            return await _scoreService.CalculateSingleScoreAsync(words);
        }
    }
}
