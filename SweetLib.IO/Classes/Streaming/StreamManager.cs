using System.IO;
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
            ObjectValue = 0x1900,
        }

        private static bool SaveMetaToStream(Stream stream, StreamedObjectType type, long length)
        {
            stream.Write(((ushort)type).ToBytes(), 0, sizeof(ushort));
            stream.Write(length.ToBytes(), 0, sizeof(long));

            return true;
        }

        private static bool LoadMetaDataFromStream(Stream stream, out StreamedObjectType type, out long length)
        {
            type = StreamedObjectType.Unknown;
            length = -1;

            // read object type
            var buffer = new byte[sizeof(ushort)];
            stream.Read(buffer, 0, buffer.Length);
            type = (StreamedObjectType) buffer.ToUInt16();

            // read data length
            buffer = new byte[sizeof(long)];
            stream.Read(buffer, 0, buffer.Length);
            length = buffer.ToInt64();

            return true;
        }

        public static void SaveToStream(Stream stream, int value)
        {
            SaveMetaToStream(stream, StreamedObjectType.IntValue, sizeof(int));
            
            stream.Write(value.ToBytes(), 0, sizeof(int));
        }

        public static void LoadFromStream(Stream stream, out int value)
        {
            StreamedObjectType type;
            long length;

            LoadMetaDataFromStream(stream, out type, out length);

            if(type!=StreamedObjectType.IntValue)
                throw new StreamTypeException($"Expected {StreamedObjectType.IntValue} but found {type} instead.");

            var buffer = new byte[length];
            stream.Read(buffer, 0, buffer.Length);
            value = buffer.ToInt32();
        }
    }
}
