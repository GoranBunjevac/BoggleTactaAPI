namespace Boggle.API.Models
{
    public class Dice
    {
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public string Letter { get; set; }

        public Dice(int xPosition, int yPosition, string letter)
        {
            XPosition = xPosition;
            YPosition = yPosition;
            Letter = letter;
        }

    }
}
