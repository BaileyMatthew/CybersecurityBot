using System;

namespace CybersecurityBot
{
    public static class AsciiArt
    {
        public static void Display()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
      ╔══════════════════════════════╗
      ║   [==== CYBER ====]         ║
      ║     _________               ║
      ║    |  O   O  |              ║
      ║    |    >    |              ║
      ║    |  \___/  |              ║
      ║    |_________|              ║
      ╚══════════════════════════════╝

          Cybersecurity Awareness Bot
            ");
            Console.ResetColor();
        }
    }
}
