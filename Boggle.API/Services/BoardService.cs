using Boggle.API.Helpers;
using Boggle.API.Interfaces;
using Boggle.API.Models;
using System;
using System.Collections.Generic;

namespace Boggle.API.Services
{
    public class BoardService : IBoardService
    {
        /// <summary>
        /// Method to create board with 16 dices.
        /// </summary>
        /// <returns>Returns 16 dices.</returns>
        public Dice[] CreateBoard()
        {
            List<Dice> dices = new List<Dice>();
            string[] letters = GenerateRandomLettersForDices();
            int letterIndex = 0;
            for (int x = 0; x < Constants.BoardSideSize; x++)
            {
                for (int y = 0; y < Constants.BoardSideSize; y++)
                {
                    dices.Add(new Dice(x, y, letters[letterIndex]));
                    letterIndex++;
                }
            }
            return dices.ToArray();
        }

        /// <summary>
        /// Method to generate random letters for dices.
        /// </summary>
        /// <returns>Returns array of random letters.</returns>
        private string[] GenerateRandomLettersForDices()
        {
            int numberOfDices = Constants.BoardSideSize * Constants.BoardSideSize;
            string[] dices = new string[numberOfDices];

            Random random = new Random();
            for (int i = 0; i < numberOfDices; i++)
            {
                int randomNumber = random.Next(0, 26);
                char letter = (char)('a' + randomNumber);
                dices[i] = letter.ToString();
            }
            
            return dices;
        }
    }
}
