using Boggle.API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Boggle.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ScoresController : ControllerBase
    {
        private IScoreService _scoreService;

        public ScoresController(IScoreService scoreService)
        {
            _scoreService = scoreService;
        }

        [HttpGet]
        public int Get([FromQuery]List<string> words)
        {
            return _scoreService.CalculateSingleScore(words);
        }
    }
}
