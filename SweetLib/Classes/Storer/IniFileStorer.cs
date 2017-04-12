using System.Runtime.InteropServices;
using System.Text;

namespace SweetLib.Classes.Storer
{
    public class IniFileStorer : IStorer
    {
        public string FileName { get; }

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public IniFileStorer(string fileName)
        {
            FileName = fileName;
        }

        public string ReadString(string section, string key, string defaultValue = "")
        {
            var builder = new StringBuilder(255);
            GetPrivateProfileString(section, key, defaultValue, builder, 255, FileName);
            return builder.ToString();
        }

        public int ReadInteger(string section, string key, int defaultValue = 0)
        {
            int result;
            if (!int.TryParse(ReadString(section, key, defaultValue.ToString()), out result))
                result = defaultValue;

            return result;
        }

        public bool ReadBool(string section, string key, bool defaultValue = false)
        {
            return ReadInteger(section, key, defaultValue ? 1 : 0) > 0;
        }

        public bool HasKey(string section, string key)
        {
            return ReadString(section, key).Length > 0;
        }

        public void WriteString(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, FileName);
        }

        public void WriteInteger(string section, string key, int value)
        {
            WriteString(section, key, value.ToString());
        }

        public void WriteBool(string section, string key, bool value)
        {
            WriteInteger(section, key, value ? 1 : 0);
        }

        public void DeleteKey(string section, string key)
        {
            WriteString(section, key, null);
        }

        public void DeleteSection(string section)
        {
            WriteString(section, null, null);
        }
    }
}
