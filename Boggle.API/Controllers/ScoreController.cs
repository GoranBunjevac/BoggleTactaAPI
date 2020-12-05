using Boggle.API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public int Get([FromQuery]List<string> words)
        {
            return _scoreService.CalculateSingleScore(words);
        }
    }
}
