using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan0021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*WelcomeBanner.DisplayWelcomeBanner();
            GameTextDescription.DisplayGameTextDescription();
            PlayerWillPlay.GetPlayerDetails();*/

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
            stringBuilder.Append("Let's play Hangman!");
            stringBuilder.Append(' ', 5);
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

            Console.WriteLine($"\t{PlayerWillPlay.FirstName}, here are some clues: \n");
            Console.WriteLine($"\tCategory: {Clues.CategoryClue()}");
            Console.WriteLine($"\tTotal letters: {Clues.SecretWordLengthClue()}");
            Console.WriteLine($"\tGuesses left: {Guess.GuessesLeft}");
            Console.WriteLine($"\tClue: {Clues.SecretWordClue()}\n");

            Console.Write("\tGuess the next letter.... ");
            Guess.GuessedLetter = Convert.ToChar(Console.ReadLine());
            
            Console.WriteLine($"\tClue: {Clues.SecretWordClue()}\n");



        }
    }
}
