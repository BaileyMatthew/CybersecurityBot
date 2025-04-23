using System;
using CybersecurityBot.Bot;
using CybersecurityBot.Helpers;

namespace CybersecurityBot.Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            VoicePlayer.PlayGreeting();
            AsciiArt.Display();
            UserInteraction.Greet();
            ChatBot.Start();
            UserInteraction.Farewell();
        }
    }
}
