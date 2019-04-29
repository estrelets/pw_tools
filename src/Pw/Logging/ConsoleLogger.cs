using System;

namespace Pw.Logging
{
    public class ConsoleLogger : ILogger
    {
        public void Info(FormattableString message) => Info(message.ToString());
        public void Debug(FormattableString message) => Debug(message.ToString());
        public void Error(FormattableString message) => Error(message.ToString());
        public void Critical(FormattableString message) => Critical(message.ToString());

        public void Info(RawString message) => Print(ConsoleColor.White, message.Value);
        public void Debug(RawString message) => Print(ConsoleColor.DarkGray, message.Value);
        public void Error(RawString message) => Print(ConsoleColor.Red, message.Value);
        public void Critical(RawString message) => Error(message.Value);

        private void Print(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
        }
    }
}
