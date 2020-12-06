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
                    return trimmedWord.Length switch
                    {
                        3 => 1,
                        4 => 1,
                        5 => 2,
                        6 => 3,
                        7 => 5,
                        _ => 0
                    };                 
                }
            }
        }
    }
}
