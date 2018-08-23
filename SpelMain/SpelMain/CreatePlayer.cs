using System;
using System.Collections.Generic;
using System.Text;

namespace SpelMain
{
    static public class CreatePlayer
    {
        static public string NameOfPlayer { get; set; }
        public static void CreatePlayez(string a)
        {
            NameOfPlayer = a;
        }
        public static void Run()
        {
            Console.Write("Enter your name: ");
            string PlayerChooseName = Console.ReadLine();
            CreatePlayez(PlayerChooseName);

            
        }
        
    }
}
