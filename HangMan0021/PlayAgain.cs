using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan0021
{
    internal class PlayAgain
    {
        public static bool PlayerWillPlayAgain = true;
        public static void WillPlayAgain()
        {
            Console.Clear();

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(' ', 20);
            stringBuilder.Append('#', 31);
            stringBuilder.Append('\n');
            stringBuilder.Append(' ', 20);
            stringBuilder.Append('#', 1);
            stringBuilder.Append(' ', 29);
            stringBuilder.Append('#', 1);
            stringBuilder.Append('\n');
            stringBuilder.Append(' ', 20);
            stringBuilder.Append('#', 1);
            stringBuilder.Append(' ', 5);
            stringBuilder.Append("Stay to play Hangman!");
            stringBuilder.Append(' ', 3);
            stringBuilder.Append('#', 1);
            stringBuilder.Append('\n');
            stringBuilder.Append(' ', 20);
            stringBuilder.Append('#', 1);
            stringBuilder.Append(' ', 29);
            stringBuilder.Append('#', 1);
            stringBuilder.Append('\n');
            stringBuilder.Append(' ', 20);
            stringBuilder.Append('#', 31);

            Console.WriteLine(stringBuilder + "\n");

            Console.Write("\tDo you want to play again? y/n: ");
            var userInput = Console.ReadLine();
            PlayerWillPlayAgain = userInput == "y" ? true : false;
            if (PlayerWillPlayAgain)
            {
                ResetGameVariables();
            }
        }

        public static void ResetGameVariables()
        {
            PlayerWillPlayAgain = true;
            PlayLoop.GameOver = false;
            Guess.GuessedLetter = '\0';
            Guess.GuessesLeft = 6;
            Guess.isFirstGuess = false;
            Guess.isVisible = true;
            Guess.count = 0;
            Clues.secretWord = SecretWord.GetSecretWord();
            Guess.secretWordWithSpaces = "";
            Guess.printString = "";
        }
    }
}
