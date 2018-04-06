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
        public static byte[] ToBytes(this short value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// Converts a <see cref="ushort"/> value into a byte array.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Byte array representation of the value.</returns>
        public static byte[] ToBytes(this ushort value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// Converts a <see cref="int"/> value into a byte array.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Byte array representation of the value.</returns>
        public static byte[] ToBytes(this int value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// Converts a <see cref="uint"/> value into a byte array.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Byte array representation of the value.</returns>
        public static byte[] ToBytes(this uint value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// Converts a <see cref="long"/> value into a byte array.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Byte array representation of the value.</returns>
        public static byte[] ToBytes(this long value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// Converts a <see cref="ulong"/> value into a byte array.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Byte array representation of the value.</returns>
        public static byte[] ToBytes(this ulong value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// Converts a <see cref="float"/> value into a byte array.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Byte array representation of the value.</returns>
        public static byte[] ToBytes(this float value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// Converts a <see cref="double"/> value into a byte array.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Byte array representation of the value.</returns>
        public static byte[] ToBytes(this double value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// Converts a <see cref="bool"/> value into a byte array.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Byte array representation of the value.</returns>
        public static byte[] ToBytes(this bool value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// Converts a <see cref="DateTime"/> value into a byte array.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Byte array representation of the value.</returns>
        public static byte[] ToBytes(this DateTime value)
        {
            return BitConverter.GetBytes(value.ToUnixTimeStamp());
        }

        /// <summary>
        /// Converts a <see cref="string"/> value into a byte array.
        /// </summary>
        /// <param name="value">Value to convert.</param>
        /// <returns>Byte array representation of the value.</returns>
        /// <remarks>Using <see cref="UTF32Encoding"/> for converting.</remarks>
        public static byte[] ToBytes(this string value)
        {
            return Encoding.UTF32.GetBytes(value);
        }

        /// <summary>
        /// Converts a <see cref="byte[]"/> into a <see cref="short"/> type.
        /// </summary>
        /// <param name="bytes">Byte array representation to convert.</param>
        /// <returns>Converted value.</returns>
        public static short ToInt16(this byte[] bytes)
        {
            return BitConverter.ToInt16(bytes, 0);
        }

        /// <summary>
        /// Converts a <see cref="byte[]"/> into a <see cref="ushort"/> type.
        /// </summary>
        /// <param name="bytes">Byte array representation to convert.</param>
        /// <returns>Converted value.</returns>
        public static ushort ToUInt16(this byte[] bytes)
        {
            return BitConverter.ToUInt16(bytes, 0);
        }

        /// <summary>
        /// Converts a <see cref="byte[]"/> into a <see cref="int"/> type.
        /// </summary>
        /// <param name="bytes">Byte array representation to convert.</param>
        /// <returns>Converted value.</returns>
        public static int ToInt32(this byte[] bytes)
        {
            return BitConverter.ToInt32(bytes, 0);
        }

        /// <summary>
        /// Converts a <see cref="byte[]"/> into a <see cref="uint"/> type.
        /// </summary>
        /// <param name="bytes">Byte array representation to convert.</param>
        /// <returns>Converted value.</returns>
        public static uint ToUInt32(this byte[] bytes)
        {
            return BitConverter.ToUInt32(bytes, 0);
        }

        /// <summary>
        /// Converts a <see cref="byte[]"/> into a <see cref="long"/> type.
        /// </summary>
        /// <param name="bytes">Byte array representation to convert.</param>
        /// <returns>Converted value.</returns>
        public static long ToInt64(this byte[] bytes)
        {
            return BitConverter.ToInt64(bytes, 0);
        }

        /// <summary>
        /// Converts a <see cref="byte[]"/> into a <see cref="ulong"/> type.
        /// </summary>
        /// <param name="bytes">Byte array representation to convert.</param>
        /// <returns>Converted value.</returns>
        public static ulong ToUInt64(this byte[] bytes)
        {
            return BitConverter.ToUInt64(bytes, 0);
        }

        /// <summary>
        /// Converts a <see cref="byte[]"/> into a <see cref="float"/> type.
        /// </summary>
        /// <param name="bytes">Byte array representation to convert.</param>
        /// <returns>Converted value.</returns>
        public static float ToSingle(this byte[] bytes)
        {
            return BitConverter.ToSingle(bytes, 0);
        }

        /// <summary>
        /// Converts a <see cref="byte[]"/> into a <see cref="double"/> type.
        /// </summary>
        /// <param name="bytes">Byte array representation to convert.</param>
        /// <returns>Converted value.</returns>
        public static double ToDouble(this byte[] bytes)
        {
            return BitConverter.ToDouble(bytes, 0);
        }

        /// <summary>
        /// Converts a <see cref="byte[]"/> into a <see cref="string"/> type.
        /// </summary>
        /// <param name="bytes">Byte array representation to convert.</param>
        /// <returns>Converted value.</returns>
        /// <remarks>Using <see cref="UTF32Encoding"/> for converting.</remarks>
        public static string ToString(this byte[] bytes)
        {
            return Encoding.UTF32.GetString(bytes);
        }
    }
}
