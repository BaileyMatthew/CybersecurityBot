using System;
using CybersecurityBot.Helpers;

namespace CybersecurityBot.Bot
{
    public static class UserInteraction
    {
        public static string UserName { get; private set; }

        public static void Greet()
        {
            TextEffects.SectionHeader("User Introduction");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Please enter your name: ");
            Console.ResetColor();

            UserName = Console.ReadLine();

            TextEffects.TypeLine($"\nWelcome, {UserName}! I'm here to help you stay safe online.", 25, ConsoleColor.Green);
        }

        public static void Farewell()
        {
            TextEffects.TypeLine($"\nGoodbye, {UserName}! Stay safe out there.", 25, ConsoleColor.Cyan);
        }
    }
}
