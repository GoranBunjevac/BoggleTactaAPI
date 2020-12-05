namespace Boggle.API.Models
{
    public class Dice
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Letter { get; set; }

        public Dice(int x, int y, string letter)
        {
            X = x;
            Y = y;
            Letter = letter;
        }

    }
}
