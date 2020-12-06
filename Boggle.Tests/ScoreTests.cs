using Boggle.API.Helpers;
using Boggle.API.Interfaces;
using Boggle.API.Models;
using Boggle.API.Services;
using Boggle.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Boggle.Tests
{
    public class ScoreTests
    {
        IScoreService scoreService = new ScoreService();

        #region Single Player Score Tests

        [Fact(DisplayName = "CalculateSingleScore Check If List Is Null")]
        public async void CalculateSingleScoreCheckIfListIsNull()
        {
            List<string> words = null;
            int score = await scoreService.CalculateSingleScoreAsync(words);
            Assert.Equal(0, score);
        }

        [Fact(DisplayName = "CalculateSingleScore Check If Words List Is Empty")]
        public async void CalculateSingleScoreCheckIfWordsListIsEmpty()
        {
            List<string> words = new List<string>();
            int score = await scoreService.CalculateSingleScoreAsync(words);
            Assert.Equal(0, score);
        }

        [Fact(DisplayName = "CalculateSingleScore Check Points For Single PLayer")]
        public async void CalculateSingleScoreCheckPointsForSinglePlayer()
        {
            List<string> words = MockData.Instance.GetSinglePlayerWords();
            int score = await scoreService.CalculateSingleScoreAsync(words);
            Assert.Equal(80, score);
        }

        [Fact(DisplayName = "CalculateSingleScore Check Points For Single Player With Duplicated Words")]
        public async void CalculateSingleScoreCheckPointsForSinglePlayerWithDuplicatedWords()
        {
            List<string> words = MockData.Instance.GetSinglePlayerDuplicatedWords();
            int score = await scoreService.CalculateSingleScoreAsync(words);
            Assert.Equal(18, score);
        }

        #endregion

        #region Multi Player Score Tests

        [Fact(DisplayName = "CalculateMultiplayerScore If Players Are Null")]
        public async System.Threading.Tasks.Task CalculateMultiplayerScoreIfPlayersAreNull()
        {
            List<Player> player = null;
            await Assert.ThrowsAsync<ArgumentNullException>(() => scoreService.CalculateMultiPlayerScoreAsync(player));
        }

        [Fact(DisplayName = "CalculateMultiplayerScore If Player List Is Empty")]
        public async void CalculateMultiplayerScoreIfPlayerListIsEmpty()
        {
            List<Player> players = new List<Player>();
            List<Player> playersWithScores = await scoreService.CalculateMultiPlayerScoreAsync(players);
            Assert.Equal(players, playersWithScores);
        }

        [Fact(DisplayName = "CalculateMultiplayerScore Check Points For Multiplayer")]
        public async void CalculateMultiplayerScore()
        {
            List<Player> players = MockData.Instance.CreateMultiPlayerWords();
            List<Player> score = await scoreService.CalculateMultiPlayerScoreAsync(players);
            Assert.True(players.Where(x => x.Id == 1).First().Score == 2);
            Assert.True(players.Where(x => x.Id == 2).First().Score == 40);
            Assert.True(players.Where(x => x.Id == 3).First().Score == 25);
            Assert.True(players.Where(x => x.Id == 4).First().Score == 22);
            Assert.True(players.Where(x => x.Id == 5).First().Score == 0);
        }

        #endregion

        #region Word Points Calculator Tests

        [Fact(DisplayName = "WordPointsCalculator Null Value Score")]
        public void WordPointsCalculatorNullValueScore()
        {
            string word = null;
            int score = WordPointsCalculator.GetPoints(word);
            Assert.Equal(0, score);
        }

        [Fact(DisplayName = "WordPointsCalculator Empty Value Score")]
        public void WordPointsCalculatorEmptyValueScore()
        {
            string word = string.Empty;
            int score = WordPointsCalculator.GetPoints(word);
            Assert.Equal(0, score);
        }

        [Fact(DisplayName = "WordPointsCalculator One Letter Score")]
        public void WordPointsCalculatorOneLetterScore()
        {
            string word = "a";
            int score = WordPointsCalculator.GetPoints(word);
            Assert.Equal(0, score);
        }

        [Fact(DisplayName = "WordPointsCalculator Two Letters Score")]
        public void WordPointsCalculatorTwoLettersScore()
        {
            string word = "ab";
            int score = WordPointsCalculator.GetPoints(word);
            Assert.Equal(0, score);
        }

        [Fact(DisplayName = "WordPointsCalculator Three Letters Score")]
        public void WordPointsCalculatorThreeLettersScore()
        {
            string word = "abc";
            int score = WordPointsCalculator.GetPoints(word);
            Assert.Equal(1, score);
        }

        [Fact(DisplayName = "WordPointsCalculator Four Letters Score")]
        public void WordPointsCalculatorFourLettersScore()
        {
            string word = "abcd";
            int score = WordPointsCalculator.GetPoints(word);
            Assert.Equal(1, score);
        }

        [Fact(DisplayName = "WordPointsCalculator Five Letters Score")]
        public void WordPointsCalculatorFiveLettersScore()
        {
            string word = "abcde";
            int score = WordPointsCalculator.GetPoints(word);
            Assert.Equal(2, score);
        }

        [Fact(DisplayName = "WordPointsCalculator Six Letters Score")]
        public void WordPointsCalculatorSixLettersScore()
        {
            string word = "abcdef";
            int score = WordPointsCalculator.GetPoints(word);
            Assert.Equal(3, score);
        }

        [Fact(DisplayName = "WordPointsCalculator Seven Letters Score")]
        public void WordPointsCalculatorSevenLettersScore()
        {
            string word = "abcdefg";
            int score = WordPointsCalculator.GetPoints(word);
            Assert.Equal(5, score);
        }

        [Fact(DisplayName = "WordPointsCalculator Eight Letters Score")]
        public void WordPointsCalculatorEightLettersScore()
        {
            string word = "abcdefgh";
            int score = WordPointsCalculator.GetPoints(word);
            Assert.Equal(11, score);
        }

        [Fact(DisplayName = "WordPointsCalculator Nine Letters Score")]
        public void WordPointsCalculatorNineLettersScore()
        {
            string word = "abcdefghi";
            int score = WordPointsCalculator.GetPoints(word);
            Assert.Equal(11, score);
        }

        #endregion
    }
}
