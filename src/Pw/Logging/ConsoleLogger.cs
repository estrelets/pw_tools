using System;

namespace Pw.Logging
{
    public class ConsoleLogger : BaseLogger
    {
        protected override void Print(string type, string message)
        {
            Console.ForegroundColor = GetColor(type);
            Console.WriteLine(message);
        }

        private ConsoleColor GetColor(string type)
        {
            return type switch
            {
                nameof(Debug) => ConsoleColor.Gray,
                nameof(Info) => ConsoleColor.White,
                nameof(Error) => ConsoleColor.DarkRed,
                nameof(Critical) => ConsoleColor.Red,
                _ => ConsoleColor.White,
            };
        }
    }
}
