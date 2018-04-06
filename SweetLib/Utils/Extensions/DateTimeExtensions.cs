using System;

namespace SweetLib.Utils.Extensions
{
    /// <summary>
    /// Defines extensions to classes which are related to <see cref="DateTime"/>.
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Converts a <see cref="DateTime"/> into an Unix timestamp.
        /// </summary>
        /// <param name="date"><see cref="DateTime"/> to convert into Unix timestamp.</param>
        /// <returns>Converted Unix timestamp.</returns>
        public static double ToUnixTimeStamp(this DateTime date)
        {
            return date.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
        }

        /// <summary>
        /// Converts an Unix timestamp into a <see cref="DateTime"/>.
        /// </summary>
        /// <param name="timestamp">Unix timestamp to convert.</param>
        /// <returns>Converted <see cref="DateTime"/>.</returns>
        public static DateTime ToDateTime(this double timestamp)
        {
            return new DateTime(1970, 1, 1).AddMilliseconds(timestamp);
        }
    }
}
