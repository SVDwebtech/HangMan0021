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
        public static bool isFirstGuess = false;
        public static bool isVisible = true;
        public static int count = 0;
        public static string secretWordWithSpaces = "";
        public static string printString = "";

        public static string EvaluateGuess()
        {
            var varUnderScoreClueCharArray = Clues.secretWordClue.ToCharArray();
            foreach (char letter in Clues.secretWord)
            {
                secretWordWithSpaces += letter + " ";
            }
            printString = "";
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
            if (secretWordWithSpaces.IndexOf(GuessedLetter) == -1 && Guess.isFirstGuess)
            {
                GuessesLeft--;
            }
            while (count >= 1)
            {
                Console.WriteLine($"\tGuesses left: {Guess.GuessesLeft}");
                count++;
                break;
            }
            count++;
            Clues.secretWordClue = printString;
            if(printString.IndexOf('_') == -1 && GuessesLeft > 0)
            {
                Console.WriteLine("\tWell done! YOU WON!");
                PlayLoop.GameOver = true;
            }
            else if (GuessesLeft < 1)
            {
                Console.WriteLine("\tSorry, no guesses left! YOU LOST!");
                PlayLoop.GameOver = true;
            }
            return printString;
        }

        public static void ChangeIsFirstGuess()
        {
            if (GuessedLetter != '\0')
            {
                Guess.isFirstGuess = true;
            }
        }
    }
}
