using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan0021
{
    internal class SecretWord
    {
        public static string GetSecretWord()
        {
            var category = Category.GetCategory();
            Random randomNum = new Random();
            var secretWord = string.Empty;

            if (category == "fruits")
            {
                var randomIndex = randomNum.Next(0, CategoriesAndWords.Fruits.Count);
                secretWord = CategoriesAndWords.Fruits[randomIndex];
            }
            else if (category == "mammals")
            {
                var randomIndex = randomNum.Next(0, CategoriesAndWords.Mammals.Count);
                secretWord = CategoriesAndWords.Mammals[randomIndex];
            }
            else if (category == "sports")
            {
                var randomIndex = randomNum.Next(0, CategoriesAndWords.Sports.Count);
                secretWord = CategoriesAndWords.Sports[randomIndex];
            }

            return secretWord;
        }
    }
}
