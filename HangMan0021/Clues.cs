using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan0021
{
    internal class Clues
    {
        public static string secretWord = SecretWord.GetSecretWord();
        public static string secretWordClue = SecretWordClue();
        
        public static string CategoryClue()
        {
            var category = String.Empty;
            
            if(CategoriesAndWords.Fruits.IndexOf(secretWord) >= 0)
            {
                category = "fruits";
            }
            else if (CategoriesAndWords.Mammals.IndexOf(secretWord) >= 0)
            {
                category = "mammals";
            }
            else if (CategoriesAndWords.Sports.IndexOf(secretWord) >= 0)
            {
                category = "sports";
            }
            return category;
        }

        public static string ReturnSecretWord()
        {
            return secretWord;
        }

        public static string SecretWordClue()
        {
            Guess.ChangeIsFirstGuess();
            string stringUnderScoreSecretWord = String.Empty;
            if (!Guess.isFirstGuess)
            {
                Guess.isVisible = false;
                var secretWordCharArray = secretWord.ToCharArray();
                var totalNumberOfUnderScoresToInsert = secretWord.Length - (secretWord.Length / 4);
                Random randNum = new Random();
                int randomIndex;
                var randomIndexList = new List<int>();
                for (int i = 0; i < totalNumberOfUnderScoresToInsert; i++)
                {
                    randomIndex = randNum.Next(0, secretWord.Length);
                    if (randomIndexList.IndexOf(randomIndex) == -1)
                    {
                        secretWordCharArray[randomIndex] = '_';
                        randomIndexList.Add(randomIndex);
                    }
                    else
                    {
                        i--;
                    }
                }
                var underScoreSecretWord = "";
                foreach (char c in secretWordCharArray)
                {
                    underScoreSecretWord += c + " ";
                }
                stringUnderScoreSecretWord = underScoreSecretWord;
            }
            else
            {
                stringUnderScoreSecretWord = Guess.EvaluateGuess();
            }
            return stringUnderScoreSecretWord;
        }

        public static int SecretWordLengthClue()
        {
            return secretWord.Length;
        }
    }
}
