using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using SweetLib.Utils.Extensions;

namespace SweetLib.IO.Classes.Streaming
{
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
            StreamedObjectType foundType;
            long length;

            LoadMetaDataFromStream(stream, out foundType, out length);

            if (foundType != type)
                throw new StreamTypeException($"Expected {type} but found {foundType} instead.");

            var buffer = new byte[length];
            stream.Read(buffer, 0, buffer.Length);

            return buffer;
        }

        public static void SaveToStream(Stream stream, string value)
        {
            SaveToStream(stream, StreamedObjectType.StringValue, value.AsBytes());
        }
        public static void SaveToStream(Stream stream, bool value)
        {
            SaveToStream(stream, StreamedObjectType.BoolValue, value.AsBytes());
        }
        public static void SaveToStream(Stream stream, char value)
        {
            SaveToStream(stream, StreamedObjectType.CharValue, value.AsBytes());
        }
        public static void SaveToStream(Stream stream, int value)
        {
            SaveToStream(stream, StreamedObjectType.IntValue, value.AsBytes());
        }
        public static void SaveToStream(Stream stream, long value)
        {
            SaveToStream(stream, StreamedObjectType.LongValue, value.AsBytes());
        }
        public static void SaveToStream(Stream stream, float value)
        {
            SaveToStream(stream, StreamedObjectType.FloatValue, value.AsBytes());
        }
        public static void SaveToStream(Stream stream, double value)
        {
            SaveToStream(stream, StreamedObjectType.DoubleValue, value.AsBytes());
        }
        public static void SaveToStream(Stream stream, DateTime value)
        {
            SaveToStream(stream, StreamedObjectType.DateTimeValue, value.AsBytes());
        }
        public static void SaveToStream(Stream stream, Stream value, bool resetSourceStream = false)
        {
            if (resetSourceStream)
                value.Position = 0;

            var buffer = new byte[value.Length - value.Position];
            value.Read(buffer, 0, buffer.Length);

            SaveToStream(stream, StreamedObjectType.StreamValue, buffer);
        }
        public static void LoadFromStream(Stream stream, out string value)
        {
            value = LoadFromStream(stream, StreamedObjectType.StringValue).AsString();
        }

        public static void LoadFromStream(Stream stream, out bool value)
        {
            value = LoadFromStream(stream, StreamedObjectType.BoolValue).AsBool();
        }
        public static void LoadFromStream(Stream stream, out char value)
        {
            value = LoadFromStream(stream, StreamedObjectType.CharValue).AsChar();
        }

        public static void LoadFromStream(Stream stream, out int value)
        {
            value = LoadFromStream(stream, StreamedObjectType.IntValue).AsInt32();
        }

        public static void LoadFromStream(Stream stream, out long value)
        {
            value = LoadFromStream(stream, StreamedObjectType.LongValue).AsInt64();
        }

        public static void LoadFromStream(Stream stream, out float value)
        {
            value = LoadFromStream(stream, StreamedObjectType.FloatValue).AsSingle();
        }

        public static void LoadFromStream(Stream stream, out double value)
        {
            value = LoadFromStream(stream, StreamedObjectType.DoubleValue).AsDouble();
        }

        public static void LoadFromStream(Stream stream, out DateTime value)
        {
            value = LoadFromStream(stream, StreamedObjectType.DateTimeValue).AsDateTime();
        }

        public static void LoadFromStream(Stream stream, out Stream value)
        {
            var buffer = LoadFromStream(stream, StreamedObjectType.StreamValue);
            value = new MemoryStream();
            value.Read(buffer, 0, buffer.Length);
        }
    }
}
