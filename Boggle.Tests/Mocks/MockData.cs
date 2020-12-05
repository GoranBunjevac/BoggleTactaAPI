using Boggle.API.Models;
using System;
using System.Collections.Generic;

namespace Boggle.Tests.Mocks
{
    public sealed class MockData
    {
        private static readonly Lazy<MockData> lazy = new Lazy<MockData>(() => new MockData());
        public static MockData Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        public List<string> GetSinglePlayerWords()
        {
            return new List<string>
            {
                "catty", "wampus", "am", "bumfuzzle", "gardyloo", "taradiddle", "loo", "snickersnee", "widdershins", "teabag", "collywobbles", "gubbins"
            };
        }

        public List<string> GetSinglePlayerDuplicatedWords()
        {
            return new List<string>
            {
                "catty", "catty", "catty", "catty", "catty", "catty", "catty", "snickersnee", "snickersnee", "snickersnee", "gubbins", "gubbins"
            };
        }

        public List<Player> CreateMultiPlayerWords()
        {
            List<Player> players = new List<Player>();

            Player player1 = new Player();
            player1.Id = 1;
            player1.Name = "Lucas";
            player1.Words = new List<string>()
            {
                "am", "bibble", "loo", "malarkey", "nudiustertian", "quire", "widdershins", "xertz", "bloviate", "pluto"
            };

            Player player2 = new Player();
            player2.Id = 2;
            player2.Name = "Clara";
            player2.Words = new List<string>()
            {
                "xertz", "gardyloo", "catty", "fuzzle", "mars", "sialoquent", "quire", "lollygag", "colly", "taradiddle", "snickersnee", "widdershins", "gardy"
            };

            Player player3 = new Player();
            player3.Id = 3;
            player3.Name = "Klaus";
            player3.Words = new List<string>()
            {
                "bumfuzzle", "wabbit", "catty", "flibbertigibbet", "am", "loo", "wampus", "lollygag", "bibble", "nudiustertian", "xertz"
            };

            Player player4 = new Player();
            player4.Id = 4;
            player4.Name = "Raphael";
            player4.Words = new List<string>()
            {
                "bloviate", "loo", "xertz", "mars", "erinaceous", "wampus", "am", "bibble", "cattywampus"
            };

            Player player5 = new Player();
            player5.Id = 5;
            player5.Name = "Tom";
            player5.Words = new List<string>()
            {
                "bibble", "loo", "snickersnee", "quire", "am", "malarkey"
            };

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            players.Add(player4);
            players.Add(player5);

            return players;
        }
    }
}
