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
            var varUnderScoreClueCharArray = Clues.secretWordClue.ToCharArray();
            string secretWordWithSpaces = "";
            foreach(char letter in Clues.secretWord)
            {
                secretWordWithSpaces += letter + " ";
            }
            var printString = "";
            for (var i = 0; i < varUnderScoreClueCharArray.Length; i++)
            {
                if (Convert.ToChar(secretWordWithSpaces[i]) == GuessedLetter)
                {
                    varUnderScoreClueCharArray[i] = GuessedLetter;
                   
                }
            }
            foreach (char c in varUnderScoreClueCharArray)
            {
                printString += c;
            }
            Clues.secretWordClue = printString;
            return printString;
        }
    }
}
