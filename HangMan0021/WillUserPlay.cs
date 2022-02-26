using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan0021
{
    internal class WillUserPlay
    {
        public static bool UserReply()
        {
            Console.Write("\tDo you want to play? y/n: ");
            var userInput = Console.ReadLine();
            var willPlay = userInput == "y" ? true : false;
            return willPlay; 
        }
    }
}
