using System;
using SweetLib.Utils.Logger.Memory;
using SweetLib.Utils.Logger.Message;

namespace SweetLib.Utils.Logger
{
    [Flags]
    public enum LogLevel
    {
        None = 0,
        Trace = 1 << 0,
        Debug = 1 << 1,
        Info = 1 << 2,
        Warn = 1 << 3,
        Error = 1 << 4
    };

    public static class Logger
    {
        public static LogLevel GlobalLogLevel { get; set; } = LogLevel.Info | LogLevel.Warn | LogLevel.Error;

        public static ILogMemory DefaultLogMemory = new ArchivableConsoleLogMemory();

        public static void Log(LogLevel logLevel, string message)
        {
            Log(logLevel, message, DefaultLogMemory);
        }

        public static void Log(LogLevel logLevel, string message, ILogMemory logMemory)
        {
            Log(new LogMessage(logLevel, message), logMemory);
        }

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

        public static void Trace(string message)
        {
            Log(LogLevel.Trace, message);
        }

        public static void Debug(string message)
        {
            Log(LogLevel.Debug, message);
        }

        public static void Info(string message)
        {
            Log(LogLevel.Info, message);
        }

        public static void Warn(string message)
        {
            Log(LogLevel.Warn, message);
        }

        public static void Error(string message)
        {
            Log(LogLevel.Error, message);
        }
    }
}
