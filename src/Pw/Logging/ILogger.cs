using System;

namespace Pw.Logging
{
    public interface ILogger
    {
        void Info(FormattableString message);
        void Debug(FormattableString message);
        void Error(FormattableString message);
        void Critical(FormattableString message);

        void Info(RawString message);
        void Debug(RawString message);
        void Error(RawString message);
        void Critical(RawString message);
    }

    public class RawString
    {
        public string Value { get; }

        private RawString(string str)
        {
            Value = str;
        }

        public static implicit operator RawString(string str)
        {
            return new RawString(str);
        }

        public static implicit operator RawString(FormattableString formattable)
        {
            return new RawString(formattable.ToString());
        }
    }
}
