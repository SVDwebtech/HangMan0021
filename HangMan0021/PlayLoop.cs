using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan0021
{
    internal class PlayLoop
    {
        public static bool GameOver = false;
        public static void DisplayPlayLoop()
        {
            while (!GameOver)
            {
                PlayBanner.DisplayPlayBanner();
                Console.WriteLine($"\t{PlayerWillPlay.FirstName}, here are some clues: \n");
                Console.WriteLine($"\tCategory: {Clues.CategoryClue()}");
                Console.WriteLine($"\tTotal letters: {Clues.SecretWordLengthClue()}");
                
                while(Guess.count <= 0)
                {
                    Console.WriteLine($"\tGuesses left: {Guess.GuessesLeft}");
                    Console.Write("\tLetters Correct: ");
                    foreach(var letter in Guess.guessesCorrect)
                    {
                        Console.Write(letter + ", ");
                    }
                    Console.WriteLine();
                    Console.Write("\tLetters Wrong: ");
                    foreach (var letter in Guess.guessesWrong)
                    {
                        Console.Write(letter + ", ");
                    }
                    Console.WriteLine();
                    Guess.count++;
                }
                Console.WriteLine($"\tClue: {Clues.secretWordClue = Clues.SecretWordClue()}\n");
                
                if (!GameOver)
                {
                    Console.Write("\tGuess the next letter.... ");
                    Guess.GuessedLetter = Convert.ToChar(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("\tPress any key to continue...");
                    Console.ReadLine();
                }  
            }
        }
    }
}
