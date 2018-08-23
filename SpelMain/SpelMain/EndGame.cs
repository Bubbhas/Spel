using System;
using System.Collections.Generic;
using System.Text;

namespace SpelMain
{
   public class EndGame
    {
        
        public void ThankPlayerForPlaying()
        {
            Console.WriteLine("You completed the game!!");
            Console.WriteLine(CreatePlayer.NameOfPlayer + ", you saved the village from a disaster!");
            Console.WriteLine("Send us some cash if you liked the game and want to play some more");
        }


    }
}
