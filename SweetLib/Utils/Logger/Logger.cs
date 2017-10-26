using System;
using SweetLib.Utils.Logger.Memory;
using SweetLib.Utils.Logger.Message;

namespace SweetLib.Utils.Logger
{
    /// <summary>
    /// Enum which contains the several log levels.
    /// </summary>
    [Flags]
    public enum LogLevel
    {
        None = 0,
        Trace = 1 << 0,
        Debug = 1 << 1,
        Info = 1 << 2,
        Warn = 1 << 3,
        Error = 1 << 4,

        All = Int32.MaxValue,
    };

    /// <summary>
    /// Global logger class providing several methods to log events by the application.
    /// </summary>
    /// <remarks>
    /// As <see cref="DefaultLogMemory"/> a <see cref="ArchivableConsoleLogMemory"/> will be used. You can change this to any other implementation at any time while runtime. 
    /// Default log levels are set as bitflags in <see cref="GlobalLogLevel"/>.
    /// </remarks>
    public static class Logger
    {
        /// <summary>
        /// The global log level. Only messages with the set <see cref="LogLevel"/> will be procedered.
        /// </summary>
        public static LogLevel GlobalLogLevel { get; set; } = LogLevel.Info | LogLevel.Warn | LogLevel.Error;

        /// <summary>
        /// The default <see cref="ILogMemory"/> which will be used for any logging action, if no custom <see cref="ILogMemory"/> is set as parameter.
        /// </summary>
        public static ILogMemory DefaultLogMemory = new ArchivableConsoleLogMemory();

        /// <summary>
        /// Will log a message into the global <see cref="DefaultLogMemory"/>.
        /// </summary>
        /// <param name="logLevel">The log level of this message.</param>
        /// <param name="message">The message to log.</param>
        public static void Log(LogLevel logLevel, string message)
        {
            Log(logLevel, message, DefaultLogMemory);
        }

        /// <summary>
        /// Will log a message into the provided <see cref="logMemory"/>.
        /// </summary>
        /// <param name="logLevel">The log level of this message.</param>
        /// /// <param name="message">The message to log.</param>
        /// <param name="logMemory">The <see cref="ILogMemory"/> to store the <see cref="message"/> into.</param>
        public static void Log(LogLevel logLevel, string message, ILogMemory logMemory)
        {
            Log(new LogMessage(logLevel, message), logMemory);
        }

        /// <summary>
        /// Will log a message into the provided <see cref="logMemory"/>.
        /// </summary>
        /// <param name="message">A <see cref="LogMessage"/> object to store.</param>
        /// <param name="logMemory">The <see cref="ILogMemory"/> to store the <see cref="message"/> into.</param>
        /// <remarks>In general use cases you should either use one of the <see cref="Log(SweetLib.Utils.Logger.LogLevel,string)"/> or <see cref="Log(SweetLib.Utils.Logger.LogLevel,string)"/> methods which will generate a call to this method.</remarks>
        public static void Log(LogMessage message, ILogMemory logMemory)
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message));

            if (logMemory == null)
                throw new ArgumentNullException(nameof(logMemory));

            if ((GlobalLogLevel & message.LogLevel) == LogLevel.None)
                return;

            logMemory.Remember(message);
        }

        /// <summary>
        /// Will log a message with the <see cref="LogLevel.Trace"/> log level.
        /// </summary>
        /// <param name="message">Message to log.</param>
        public static void Trace(string message)
        {
            Log(LogLevel.Trace, message);
        }

        /// <summary>
        /// Will log a message with the <see cref="LogLevel.Debug"/> log level.
        /// </summary>
        /// <param name="message">Message to log.</param>
        public static void Debug(string message)
        {
            Log(LogLevel.Debug, message);
        }

        /// <summary>
        /// Will log a message with the <see cref="LogLevel.Info"/> log level.
        /// </summary>
        /// <param name="message">Message to log.</param>
        public static void Info(string message)
        {
            Log(LogLevel.Info, message);
        }

        /// <summary>
        /// Will log a message with the <see cref="LogLevel.Warn"/> log level.
        /// </summary>
        /// <param name="message">Message to log.</param>
        public static void Warn(string message)
        {
            Log(LogLevel.Warn, message);
        }

        /// <summary>
        /// Will log a message with the <see cref="LogLevel.Error"/> log level.
        /// </summary>
        /// <param name="message">Message to log.</param>
        public static void Error(string message)
        {
            Log(LogLevel.Error, message);
        }
    }
}
