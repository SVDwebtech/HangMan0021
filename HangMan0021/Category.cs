using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan0021
{
    internal class Category
    {
        public static string GetCategory()
        {
            Random randomNum = new Random();
            var randomIndex = randomNum.Next(0, CategoriesAndWords.Categories.Count);

            return CategoriesAndWords.Categories[randomIndex];
        }
    }
}
