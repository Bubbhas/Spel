using System;
using System.Collections.Generic;
using System.Text;

namespace SpelMain
{
    public class CreatePlayer
    {
        public string NameOfPlayer { get; set; }

        public void StartPlayerCreation()
        {
            CreateName();
        }
        public void CreateName()
        {
            Console.Write("Enter your name: ");
            string PlayerChooseName = Console.ReadLine();
            NameOfPlayer = PlayerChooseName;
            Console.WriteLine($"Greetings {NameOfPlayer}");
        }
    }
}
