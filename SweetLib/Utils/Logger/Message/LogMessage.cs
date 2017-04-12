using System;
using System.Globalization;

namespace SweetLib.Utils.Logger.Message
{
    public class LogMessage : IFormattable
    {
        public LogLevel LogLevel { get; }
        public string Message { get; }
        public DateTime LogDateTime { get; }

        public LogMessage(LogLevel logLevel, string message) : this(logLevel, message, DateTime.Now) { }

        public LogMessage(LogLevel logLevel, string message, DateTime logDateTime)
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message));

            if (logDateTime == null)
                throw new ArgumentNullException(nameof(logDateTime));

            LogLevel = logLevel;
            Message = message;
            LogDateTime = logDateTime;
        }

        public override string ToString()
        {
            return ToString($"[{CultureInfo.CurrentCulture.DateTimeFormat}] (LL) - V", CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return LogMessageFormatter.Instance.Format(format, this, formatProvider);
        }
    }
}
