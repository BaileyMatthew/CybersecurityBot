using System;
using System.Threading;

namespace CybersecurityBot.Helpers
{
    public static class TextEffects
    {
        public static void TypeLine(string text, int delay = 20, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void SectionHeader(string title)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n" + new string('=', 60));
            Console.WriteLine($"{title.ToUpper()}");
            Console.WriteLine(new string('=', 60));
            Console.ResetColor();
        }

        public static void Divider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(new string('-', 60));
            Console.ResetColor();
        }

        internal static void TypeLine(object value, int v)
        {
            throw new NotImplementedException();
        }
    }
}
