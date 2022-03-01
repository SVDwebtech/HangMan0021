using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan0021
{
    internal class PlayLoop
    {
        public static void DisplayPlayLoop()
        {
            while (true)
            {
                PlayBanner.DisplayPlayBanner();
                Console.WriteLine($"\t{PlayerWillPlay.FirstName}, here are some clues: \n");
                Console.WriteLine($"\tCategory: {Clues.CategoryClue()}");
                Console.WriteLine($"\tTotal letters: {Clues.SecretWordLengthClue()}");
                Console.WriteLine("\tGuess.isVisible: " + Guess.isVisible);

                while(Guess.count <= 0)
                {
                    Console.WriteLine($"\tGuesses left: {Guess.GuessesLeft}");
                    Guess.count++;
                }
                Console.WriteLine($"\tClue: {Clues.SecretWordClue()}\n");

                Console.Write("\tGuess the next letter.... ");
                Guess.GuessedLetter = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
