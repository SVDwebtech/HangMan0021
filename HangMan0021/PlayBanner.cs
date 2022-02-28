using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan0021
{
    internal class PlayBanner
    {
        public static void DisplayPlayBanner()
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
        }
    }
}
