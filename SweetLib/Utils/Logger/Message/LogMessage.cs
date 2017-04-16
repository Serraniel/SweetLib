using System;
using System.Globalization;

namespace SweetLib.Utils.Logger.Message
{
    /// <summary>
    /// <see cref="LogMessage"/> contains all event log data which should be logged in as a single log message.
    /// </summary>
    public class LogMessage : IFormattable
    {
        /// <summary>
        /// The <see cref="LogLevel"/> of this event log.
        /// </summary>
        public LogLevel LogLevel { get; }

        /// <summary>
        /// The message of this event log.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// The date and time of this event log.
        /// </summary>
        public DateTime LogDateTime { get; }

        /// <summary>
        /// Creates a new <see cref="LogMessage"/> instance. <see cref="DateTime.Now"/> will be the <see cref="LogDateTime"/>.
        /// </summary>
        /// <param name="logLevel">The log level of this event log.</param>
        /// <param name="message">The message of this event log.</param>
        public LogMessage(LogLevel logLevel, string message) : this(logLevel, message, DateTime.Now) { }

        /// <summary>
        /// Creates a new <see cref="LogMessage"/> instance.
        /// </summary>
        /// <param name="logLevel">The log level of this event log.</param>
        /// <param name="message">The message of this event log.</param>
        /// <param name="logDateTime">The <see cref="DateTime"/> of this event log.</param>
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

        /// <summary>
        /// Generates a formatted <see cref="string"/> of this event log. <see cref="LogMessageFormatter.DefaultFormatString"/> will be used to format this event log.
        /// </summary>
        /// <returns>A formated <see cref="string"/> of this event log.</returns>
        public override string ToString()
        {
            return ToString(LogMessageFormatter.DefaultFormatString, CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Generates a formatted <see cref="string"/> of this event log with a given format.
        /// </summary>
        /// <param name="format">The format to be used. See <see cref="LogMessageFormatter"/> for more format information.</param>
        /// <param name="formatProvider">Optional, an <see cref="IFormatProvider"/> interface to be used while formatting if needed.</param>
        /// <returns>A formated <see cref="string"/> of this event log.</returns>
        public string ToString(string format, IFormatProvider formatProvider = null)
        {
            return LogMessageFormatter.Instance.Format(format, this, formatProvider);
        }
    }
}
