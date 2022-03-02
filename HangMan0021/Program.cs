using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan0021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeBanner.DisplayWelcomeBanner();
            GameTextDescription.DisplayGameTextDescription();
            PlayerWillPlay.GetPlayerDetails();
            while (PlayAgain.PlayerWillPlayAgain)
            {
                PlayLoop.DisplayPlayLoop();
                PlayAgain.WillPlayAgain();
                
            }
            


        }
    }
}
