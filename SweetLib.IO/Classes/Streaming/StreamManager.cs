using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using SweetLib.Utils.Extensions;

namespace SweetLib.IO.Classes.Streaming
{
    /// <summary>
    /// <see cref="StreamManager"/> wraps some useful methods for custom implementations of object streaming.
    /// </summary>
    public static class StreamManager
    {
        enum StreamedObjectType : ushort // 2 bytes
        {
            Unknown = 0x0000,
            StringValue = 0x1100,
            BoolValue = 0x1200,
            CharValue = 0x1300,
            IntValue = 0x1400,
            LongValue = 0x1410,
            FloatValue = 0x1500,
            DoubleValue = 0x1600,
            DateTimeValue = 0x1700,
            StreamValue = 0x1800,
        }

        private static bool SaveMetaToStream(Stream stream, StreamedObjectType type, long length)
        {
            stream.Write(((ushort)type).AsBytes(), 0, sizeof(ushort));
            stream.Write(length.AsBytes(), 0, sizeof(long));

            return true;
        }

        private static bool LoadMetaDataFromStream(Stream stream, out StreamedObjectType type, out long length)
        {
            type = StreamedObjectType.Unknown;
            length = -1;

            // read object type
            var buffer = new byte[sizeof(ushort)];
            stream.Read(buffer, 0, buffer.Length);
            type = (StreamedObjectType)buffer.AsUInt16();

            // read data length
            buffer = new byte[sizeof(long)];
            stream.Read(buffer, 0, buffer.Length);
            length = buffer.AsInt64();

            return true;
        }

        private static void SaveToStream(Stream stream, StreamedObjectType type, byte[] buffer)
        {
            SaveMetaToStream(stream, type, buffer.Length);
            stream.Write(buffer, 0, buffer.Length);
        }

        private static byte[] LoadFromStream(Stream stream, StreamedObjectType type)
        {
            long length;

            LoadMetaDataFromStream(stream, out StreamedObjectType foundType, out length);

            if (foundType != type)
                throw new StreamTypeException($"Expected {type} but found {foundType} instead.");

            var buffer = new byte[length];
            stream.Read(buffer, 0, buffer.Length);

            return buffer;
        }

        /// <summary>
        /// Adds a <see cref="string"/> to a given <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream"><see cref="Stream"/> to which the <see cref="string"/> will be added.</param>
        /// <param name="value"><see cref="string"/> value to add.</param>
        public static void SaveToStream(Stream stream, string value)
        {
            SaveToStream(stream, StreamedObjectType.StringValue, value.AsBytes());
        }

        /// <summary>
        /// Adds a <see cref="bool"/> to a given <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream"><see cref="Stream"/> to which the <see cref="bool"/> will be added.</param>
        /// <param name="value"><see cref="bool"/> value to add.</param>
        public static void SaveToStream(Stream stream, bool value)
        {
            SaveToStream(stream, StreamedObjectType.BoolValue, value.AsBytes());
        }

        /// <summary>
        /// Adds a <see cref="char"/> to a given <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream"><see cref="Stream"/> to which the <see cref="char"/> will be added.</param>
        /// <param name="value"><see cref="char"/> value to add.</param>
        public static void SaveToStream(Stream stream, char value)
        {
            SaveToStream(stream, StreamedObjectType.CharValue, value.AsBytes());
        }

        /// <summary>
        /// Adds a <see cref="int"/> to a given <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream"><see cref="Stream"/> to which the <see cref="int"/> will be added.</param>
        /// <param name="value"><see cref="int"/> value to add.</param>
        public static void SaveToStream(Stream stream, int value)
        {
            SaveToStream(stream, StreamedObjectType.IntValue, value.AsBytes());
        }

        /// <summary>
        /// Adds a <see cref="long"/> to a given <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream"><see cref="Stream"/> to which the <see cref="long"/> will be added.</param>
        /// <param name="value"><see cref="long"/> value to add.</param>
        public static void SaveToStream(Stream stream, long value)
        {
            SaveToStream(stream, StreamedObjectType.LongValue, value.AsBytes());
        }

        /// <summary>
        /// Adds a <see cref="float"/> to a given <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream"><see cref="Stream"/> to which the <see cref="float"/> will be added.</param>
        /// <param name="value"><see cref="float"/> value to add.</param>
        public static void SaveToStream(Stream stream, float value)
        {
            SaveToStream(stream, StreamedObjectType.FloatValue, value.AsBytes());
        }

        /// <summary>
        /// Adds a <see cref="double"/> to a given <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream"><see cref="Stream"/> to which the <see cref="double"/> will be added.</param>
        /// <param name="value"><see cref="double"/> value to add.</param>
        public static void SaveToStream(Stream stream, double value)
        {
            SaveToStream(stream, StreamedObjectType.DoubleValue, value.AsBytes());
        }

        /// <summary>
        /// Adds a <see cref="DateTime"/> to a given <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream"><see cref="Stream"/> to which the <see cref="DateTime"/> will be added.</param>
        /// <param name="value"><see cref="DateTime"/> value to add.</param>
        public static void SaveToStream(Stream stream, DateTime value)
        {
            SaveToStream(stream, StreamedObjectType.DateTimeValue, value.AsBytes());
        }

        /// <summary>
        /// Adds a <see cref="Stream"/> to a given <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream"><see cref="Stream"/> to which the <see cref="Stream"/> will be added.</param>
        /// <param name="value"><see cref="Stream"/> value to add.</param>
        public static void SaveToStream(Stream stream, Stream value, bool resetSourceStream = false)
        {
            if (resetSourceStream)
                value.Position = 0;

            var buffer = new byte[value.Length - value.Position];
            value.Read(buffer, 0, buffer.Length);

            SaveToStream(stream, StreamedObjectType.StreamValue, buffer);
        }

        /// <summary>
        /// Loads a <see cref="string"/> from a given <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream"><see cref="Stream"/> from which the <see cref="string"/> will be loaded.</param>
        /// <param name="value">Contains the loaded <see cref="string"/> value.</param>
        public static void LoadFromStream(Stream stream, out string value)
        {
            value = LoadFromStream(stream, StreamedObjectType.StringValue).AsString();
        }

        /// <summary>
        /// Loads a <see cref="bool"/> from a given <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream"><see cref="Stream"/> from which the <see cref="bool"/> will be loaded.</param>
        /// <param name="value">Contains the loaded <see cref="bool"/> value.</param>
        public static void LoadFromStream(Stream stream, out bool value)
        {
            value = LoadFromStream(stream, StreamedObjectType.BoolValue).AsBool();
        }

        /// <summary>
        /// Loads a <see cref="char"/> from a given <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream"><see cref="Stream"/> from which the <see cref="char"/> will be loaded.</param>
        /// <param name="value">Contains the loaded <see cref="char"/> value.</param>
        public static void LoadFromStream(Stream stream, out char value)
        {
            value = LoadFromStream(stream, StreamedObjectType.CharValue).AsChar();
        }

        /// <summary>
        /// Loads a <see cref="int"/> from a given <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream"><see cref="Stream"/> from which the <see cref="int"/> will be loaded.</param>
        /// <param name="value">Contains the loaded <see cref="int"/> value.</param>
        public static void LoadFromStream(Stream stream, out int value)
        {
            value = LoadFromStream(stream, StreamedObjectType.IntValue).AsInt32();
        }

        /// <summary>
        /// Loads a <see cref="long"/> from a given <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream"><see cref="Stream"/> from which the <see cref="long"/> will be loaded.</param>
        /// <param name="value">Contains the loaded <see cref="long"/> value.</param>
        public static void LoadFromStream(Stream stream, out long value)
        {
            value = LoadFromStream(stream, StreamedObjectType.LongValue).AsInt64();
        }

        /// <summary>
        /// Loads a <see cref="string"/> from a given <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream"><see cref="Stream"/> from which the <see cref="string"/> will be loaded.</param>
        /// <param name="value">Contains the loaded <see cref="string"/> value.</param>
        public static void LoadFromStream(Stream stream, out float value)
        {
            value = LoadFromStream(stream, StreamedObjectType.FloatValue).AsSingle();
        }

        /// <summary>
        /// Loads a <see cref="double"/> from a given <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream"><see cref="Stream"/> from which the <see cref="double"/> will be loaded.</param>
        /// <param name="value">Contains the loaded <see cref="double"/> value.</param>
        public static void LoadFromStream(Stream stream, out double value)
        {
            value = LoadFromStream(stream, StreamedObjectType.DoubleValue).AsDouble();
        }

        /// <summary>
        /// Loads a <see cref="DateTime"/> from a given <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream"><see cref="Stream"/> from which the <see cref="DateTime"/> will be loaded.</param>
        /// <param name="value">Contains the loaded <see cref="DateTime"/> value.</param>
        public static void LoadFromStream(Stream stream, out DateTime value)
        {
            value = LoadFromStream(stream, StreamedObjectType.DateTimeValue).AsDateTime();
        }

        /// <summary>
        /// Loads a <see cref="Stream"/> from a given <see cref="Stream"/>.
        /// </summary>
        /// <param name="stream"><see cref="Stream"/> from which the <see cref="Stream"/> will be loaded.</param>
        /// <param name="value">Contains the loaded <see cref="Stream"/> value.</param>
        public static void LoadFromStream(Stream stream, out Stream value)
        {
            var buffer = LoadFromStream(stream, StreamedObjectType.StreamValue);
            value = new MemoryStream();
            value.Read(buffer, 0, buffer.Length);
        }
    }
}
