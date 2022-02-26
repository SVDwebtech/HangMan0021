using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan0021
{
    internal class GameTextDescription
    {
        public static void DisplayGameTextDescription()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n");
            stringBuilder.Append("\tHangman is a simple word guessing game where the computer\n" +
                                 "\tgenerates a secret word, phrase or sentence. The player then\n" +
                                 "\tattempts to discover the secret word, phrase or sentence by\n" +
                                 "\tguessing one letter at a time. Each time the player guesses\n" +
                                 "\ta letter which does not appear in the secret word, phrase or\n" +
                                 "\tsentence, the hangman picture is drawn further. The player\n" +
                                 "\tmust discover the whole word, phrase or sentence before the\n" +
                                 "\t(the picture is fully drawn) player is hanged! :-(\n");

            Console.WriteLine(stringBuilder);

        }
    }
}
