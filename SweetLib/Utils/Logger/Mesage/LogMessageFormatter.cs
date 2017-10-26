using System;
using System.Globalization;

namespace SweetLib.Utils.Logger.Message
{
    /// <summary>
    /// A <see cref="ICustomFormatter"/> which is used to format <see cref="LogMessage"/> objects.
    /// </summary>
    /// <remarks>This class implements a singleton pattern.</remarks>
    public class LogMessageFormatter : ICustomFormatter
    {

        private LogMessageFormatter() { }

        private static object Locker { get; } = new object();

        /// <summary>
        /// Accesses the global instance of the <see cref="LogMessageFormatter"/>.
        /// </summary>
        private static LogMessageFormatter FormatterInstance { get; set; }

        public static string DefaultFormatString { get; set; } = $"[{CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern} - {CultureInfo.CurrentCulture.DateTimeFormat.LongTimePattern}] (LL): V";

        /// <summary>
        /// The default format string which is used to format <see cref="LogMessage"/> objects, if no custom format string is provided.
        /// </summary>
        public static LogMessageFormatter Instance
        {
            get
            {
                if (FormatterInstance != null)
                    return FormatterInstance;

                lock (Locker)
                {
                    if (FormatterInstance != null)
                        return FormatterInstance;

                    FormatterInstance = new LogMessageFormatter();
                }
                return FormatterInstance;
            }
        }

        /// <summary>
        /// Formats a <see cref="LogMessage"/> object.
        /// </summary>
        /// <param name="format">The format string. If <see cref="null"/>, <see cref="DefaultFormatString"/> will be used.</param>
        /// <param name="arg">The <see cref="LogMessage"/> object to be formatted.</param>
        /// <param name="formatProvider">Optional, an <see cref="IFormatProvider"/> interface to be used while formatting if needed.</param>
        /// <returns>A formatted <see cref="string"/> of the <see cref="LogMessage"/>.</returns>
        /// <remarks>
        /// If <see cref="arg"/> is not a <see cref="LogMessage"/> object, it will either be returned the formatted string implemented by the type of <see cref="arg"/>, if <see cref="IFormattable"/> is implemented by it, or the <see cref="arg.ToString()"/> result."
        /// </remarks>
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (format == null)
                format = DefaultFormatString;

            if (arg == null)
                throw new ArgumentNullException(nameof(arg));

            if (arg.GetType() != typeof(LogMessage))
            {
                var formattable = arg as IFormattable;
                return formattable?.ToString(format, formatProvider) ?? arg.ToString();
            }

            var message = (LogMessage)arg;

            var result = message.LogDateTime.ToString(format, formatProvider);

            result = result.Replace("LL", message.LogLevel.ToString());
            result = result.Replace("V", message.Message);

            return result;
        }
    }
}
