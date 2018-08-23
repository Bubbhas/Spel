using System;
using System.Collections.Generic;
using System.Text;

namespace SpelMain
{
    class StartGame
    {
        public static void Run()
        {
            GreetPlayer();
            ChooseMission();
        }

        private static void GreetPlayer()
        {
            Console.WriteLine("Hello there " + CreatePlayer.NameOfPlayer + "!. That looks like a nice " + CreatePlayer.Weapon + " you got there");
        }

        public static void ChooseMission()
        {

        }
    }
}
