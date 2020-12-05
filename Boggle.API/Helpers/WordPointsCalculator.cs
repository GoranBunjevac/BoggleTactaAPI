namespace Boggle.API.Helpers
{
    public static class WordPointsCalculator
    {
        /// <summary>
        /// Method calculates points based on word length.
        /// </summary>
        /// <param name="word"></param>
        /// <returns>Integer value of points.</returns>
        public static int GetPoints(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return 0;
            }
            else
            {
                string trimmedWord = word.Trim();

                if (trimmedWord.Length >= 8)
                {
                    return 11;
                }
                else
                {
                    switch (trimmedWord.Length)
                    {
                        case 3:
                        case 4:
                            return 1;
                        case 5:
                            return 2;
                        case 6:
                            return 3;
                        case 7:
                            return 5;
                        default:
                            return 0;
                    }
                }
            }
        }
    }
}
