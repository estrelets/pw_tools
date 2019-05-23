using System;

namespace Pw.Logging
{
    public abstract class BaseLogger : ILogger
    {
        public void Info(FormattableString message) => Info(message.ToString());
        public void Debug(FormattableString message) => Debug(message.ToString());
        public void Error(FormattableString message) => Error(message.ToString());
        public void Critical(FormattableString message) => Critical(message.ToString());

        public void Info(RawString message) => Print(nameof(Info), message.Value);
        public void Debug(RawString message) => Print(nameof(Debug), message.Value);
        public void Error(RawString message) => Print(nameof(Error), message.Value);
        public void Critical(RawString message) => Print(nameof(Critical), message.Value);

        protected abstract void Print(string type, string message);
    }
}
