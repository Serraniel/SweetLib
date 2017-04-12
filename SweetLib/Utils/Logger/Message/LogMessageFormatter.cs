using System;
using System.Globalization;

namespace SweetLib.Utils.Logger.Message
{
    public class LogMessageFormatter : ICustomFormatter
    {

        private LogMessageFormatter() { }

        private static object Locker { get; } = new object();

        public static LogMessageFormatter FormatterInstance { get; set; }

        public static string DefaultFormatString { get; set; } = $"[{CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern} - {CultureInfo.CurrentCulture.DateTimeFormat.LongTimePattern}] (LL): V";

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

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (format == null)
                throw new ArgumentNullException(nameof(format));

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
