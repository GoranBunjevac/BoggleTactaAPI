using Boggle.API.Helpers;
using Boggle.API.Interfaces;
using Boggle.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Boggle.API.Services
{
    public class ScoreService : IScoreService
    {        
        /// <summary>
        /// Method calculates score for list of words based on words length.
        /// </summary>
        /// <param name="words"></param>
        /// <returns>Score represented in integer.</returns>
        public int CalculateSingleScore(List<string> words)
        {
            if (words == null || words.Count == 0)
            {
                return 0;
            }

            // Remove duplicate words in list if any
            List<string> uniqueWords = words.Where(w => !string.IsNullOrWhiteSpace(w))
                                            .Select(w => w.Trim().ToLower())
                                            .Distinct()
                                            .ToList();
            int score = 0;
            uniqueWords.ForEach(word => score += WordPointsCalculator.GetPoints(word));
            return score;
        }

        /// <summary>
        /// Method calculates score for list of words per player.
        /// </summary>
        /// <param name="players"></param>
        /// <returns>List of player objects.</returns>
        public List<Player> CalculateMultiplayerScore(List<Player> players)
        {
            if (players == null)
            {
                throw new ArgumentNullException("There are no players.");
            }

            List<string> wordsFromAllPlayers = players.Select(p => p.Words)
                                           .Aggregate(new List<string>(), (res, word) => res.Concat(word).ToList());

            List<string> uniqueWords = wordsFromAllPlayers.Where(w => !string.IsNullOrWhiteSpace(w) && wordsFromAllPlayers.Count(a => !string.IsNullOrWhiteSpace(a) && a.Trim().ToLower() == w.Trim().ToLower()) == 1)
                                                      .Select(w => w.Trim().ToLower())
                                                      .Distinct()
                                                      .ToList();
            foreach (Player player in players)
            {
                List<string> playerUniqueWords = player.Words
                                                       .Where(w => !string.IsNullOrWhiteSpace(w) && uniqueWords.Any(n => w.Trim().ToLower() == n))
                                                       .ToList();

                player.Score = CalculateSingleScore(playerUniqueWords);
            }

            return players;
        }
    }
}
