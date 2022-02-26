using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan0021
{
    internal class Guess
    {
        public static char GuessedLetter;
        public static int GuessesLeft = 6;

        public static string EvaluateGuess()
        {
            GuessesLeft--;
            var varUnderScoreClueCharArray = Clues.GetUnderscoreSecretWord().ToCharArray();
            for(var i = 0; i < Clues.SecretWordClue().Length; i++)
            {
                if (Clues.SecretWordClue()[i] == GuessedLetter)
                {
                    varUnderScoreClueCharArray[i] = GuessedLetter;
                }
            }

            return varUnderScoreClueCharArray.ToString();
        }
    }
}
