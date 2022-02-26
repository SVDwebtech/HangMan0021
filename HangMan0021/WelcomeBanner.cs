using System;
using System.Text;

namespace HangMan0021
{
    public class WelcomeBanner
    {
        public static void DisplayWelcomeBanner()
        {
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
            stringBuilder.Append("Welcome to Hangman!");
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

            Console.WriteLine(stringBuilder);
        }
    }
}
