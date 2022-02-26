using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan0021
{
    internal class PlayerWillPlay
    {
        
        public static string FirstName;
        public static string LastName;
        public static int Age;

        public static void GetPlayerDetails()
        {
            if (WillUserPlay.UserReply())
            {
                Console.WriteLine();
                Console.Write("\tWhat is your first name?: ");
                FirstName = Console.ReadLine();
                Console.Write("\tWhat is your last name?: ");
                LastName = Console.ReadLine();
                Console.Write("\tWhat is your age?: ");
                Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine($"\tHello {PlayerWillPlay.FirstName} {PlayerWillPlay.LastName}, and welcome to Hangman.\n" +
                                  $"\tYou are a {PlayerWillPlay.Age} years old and will play on an adult level.\n" +
                                  $"\tPress any key to continue to play...");
                Console.WriteLine();
                Console.ReadLine();
            }
        }

    }
}
