using System.Collections.Generic;

namespace Boggle.API.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Words { get; set; }
        public int Score { get; set; }
    }
}
