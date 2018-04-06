using System;
using System.Text;

namespace SweetLib.Utils.Extensions
{
    /// <summary>
    /// Defines extensions to some general classes.
    /// </summary>
    public static class BaseTypeExtensions
    {
        /// <summary>
        /// Converts a <see cref="short"/> value into a byte array.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Byte array representation of the value.</returns>
        public static byte[] AsBytes(this short value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// Converts a <see cref="ushort"/> value into a byte array.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Byte array representation of the value.</returns>
        public static byte[] AsBytes(this ushort value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// Converts a <see cref="int"/> value into a byte array.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Byte array representation of the value.</returns>
        public static byte[] AsBytes(this int value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// Converts a <see cref="uint"/> value into a byte array.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Byte array representation of the value.</returns>
        public static byte[] AsBytes(this uint value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// Converts a <see cref="long"/> value into a byte array.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Byte array representation of the value.</returns>
        public static byte[] AsBytes(this long value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// Converts a <see cref="ulong"/> value into a byte array.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Byte array representation of the value.</returns>
        public static byte[] AsBytes(this ulong value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// Converts a <see cref="float"/> value into a byte array.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Byte array representation of the value.</returns>
        public static byte[] AsBytes(this float value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// Converts a <see cref="double"/> value into a byte array.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Byte array representation of the value.</returns>
        public static byte[] AsBytes(this double value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// Converts a <see cref="bool"/> value into a byte array.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Byte array representation of the value.</returns>
        public static byte[] AsBytes(this bool value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// Converts a <see cref="DateTime"/> value into a byte array.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Byte array representation of the value.</returns>
        public static byte[] AsBytes(this DateTime value)
        {
            return BitConverter.GetBytes(value.ToUnixTimeStamp());
        }

        /// <summary>
        /// Converts a <see cref="string"/> value into a byte array.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Byte array representation of the value.</returns>
        /// <remarks>Using <see cref="UTF32Encoding"/> for converting.</remarks>
        public static byte[] AsBytes(this string value)
        {
            return Encoding.UTF32.GetBytes(value);
        }

        /// <summary>
        /// Converts a <see cref="char"/> value into a byte array.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Byte array representation of the value.</returns>
        public static byte[] AsBytes(this char value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// Converts a <see cref="byte[]"/> into a <see cref="short"/> type.
        /// </summary>
        /// <param name="bytes">Byte array representation to convert.</param>
        /// <returns>Converted value.</returns>
        public static short AsInt16(this byte[] bytes)
        {
            return BitConverter.ToInt16(bytes, 0);
        }

        /// <summary>
        /// Converts a <see cref="byte[]"/> into a <see cref="ushort"/> type.
        /// </summary>
        /// <param name="bytes">Byte array representation to convert.</param>
        /// <returns>Converted value.</returns>
        public static ushort AsUInt16(this byte[] bytes)
        {
            return BitConverter.ToUInt16(bytes, 0);
        }

        /// <summary>
        /// Converts a <see cref="byte[]"/> into a <see cref="int"/> type.
        /// </summary>
        /// <param name="bytes">Byte array representation to convert.</param>
        /// <returns>Converted value.</returns>
        public static int AsInt32(this byte[] bytes)
        {
            return BitConverter.ToInt32(bytes, 0);
        }

        /// <summary>
        /// Converts a <see cref="byte[]"/> into a <see cref="uint"/> type.
        /// </summary>
        /// <param name="bytes">Byte array representation to convert.</param>
        /// <returns>Converted value.</returns>
        public static uint AsUInt32(this byte[] bytes)
        {
            return BitConverter.ToUInt32(bytes, 0);
        }

        /// <summary>
        /// Converts a <see cref="byte[]"/> into a <see cref="long"/> type.
        /// </summary>
        /// <param name="bytes">Byte array representation to convert.</param>
        /// <returns>Converted value.</returns>
        public static long AsInt64(this byte[] bytes)
        {
            return BitConverter.ToInt64(bytes, 0);
        }

        /// <summary>
        /// Converts a <see cref="byte[]"/> into a <see cref="ulong"/> type.
        /// </summary>
        /// <param name="bytes">Byte array representation to convert.</param>
        /// <returns>Converted value.</returns>
        public static ulong AsUInt64(this byte[] bytes)
        {
            return BitConverter.ToUInt64(bytes, 0);
        }

        /// <summary>
        /// Converts a <see cref="byte[]"/> into a <see cref="float"/> type.
        /// </summary>
        /// <param name="bytes">Byte array representation to convert.</param>
        /// <returns>Converted value.</returns>
        public static float AsSingle(this byte[] bytes)
        {
            return BitConverter.ToSingle(bytes, 0);
        }

        /// <summary>
        /// Converts a <see cref="byte[]"/> into a <see cref="double"/> type.
        /// </summary>
        /// <param name="bytes">Byte array representation to convert.</param>
        /// <returns>Converted value.</returns>
        public static double AsDouble(this byte[] bytes)
        {
            return BitConverter.ToDouble(bytes, 0);
        }

        /// <summary>
        /// Converts a <see cref="byte[]"/> into a <see cref="bool"/> type.
        /// </summary>
        /// <param name="bytes">Byte array representation to convert.</param>
        /// <returns>Converted value.</returns>
        public static bool AsBool(this byte[] bytes)
        {
            return BitConverter.ToBoolean(bytes, 0);
        }

        /// <summary>
        /// Converts a <see cref="byte[]"/> into a <see cref="DateTime"/> type.
        /// </summary>
        /// <param name="bytes">Byte array representation to convert.</param>
        /// <returns>Converted value.</returns>
        public static DateTime AsDateTime(this byte[] bytes)
        {
            return BitConverter.ToDouble(bytes, 0).ToDateTime();
        }

        /// <summary>
        /// Converts a <see cref="byte[]"/> into a <see cref="string"/> type.
        /// </summary>
        /// <param name="bytes">Byte array representation to convert.</param>
        /// <returns>Converted value.</returns>
        /// <remarks>Using <see cref="UTF32Encoding"/> for converting.</remarks>
        public static string AsString(this byte[] bytes)
        {
            return Encoding.UTF32.GetString(bytes);
        }

        /// <summary>
        /// Converts a <see cref="byte[]"/> into a <see cref="char"/> type.
        /// </summary>
        /// <param name="bytes">Byte array representation to convert.</param>
        /// <returns>Converted value.</returns>
        public static char AsChar(this byte[] bytes)
        {
            return BitConverter.ToChar(bytes, 0);
        }
    }
}
