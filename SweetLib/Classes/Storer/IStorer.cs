namespace SweetLib.Classes.Storer
{
    public interface IStorer
    {
        string ReadString(string section, string key, string defaultValue = "");

        int ReadInteger(string section, string key, int defaultValue = 0);

        bool ReadBool(string section, string key, bool defaultValue = false);

        bool HasKey(string section, string key);

        void WriteString(string section, string key, string value);

        void WriteInteger(string section, string key, int value);

        void WriteBool(string section, string key, bool value);

        void DeleteKey(string section, string key);

        void DeleteSection(string section);
    }
}
