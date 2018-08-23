using System;
using System.Collections.Generic;
using System.Text;

namespace SpelMain
{
    class CreatePlayer
    {
        public string NameOfPlayer { get; set; }
        public void Run()
        {
            CreateName();
        }
        public string CreateName()
        {
            Console.Write("Enter your name: ");
            string PlayerChooseName = Console.ReadLine();
            NameOfPlayer = PlayerChooseName;
            Console.WriteLine($"Greetings {NameOfPlayer}");
        }
    }
}
