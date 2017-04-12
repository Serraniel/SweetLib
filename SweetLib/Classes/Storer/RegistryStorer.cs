using Microsoft.Win32;
using SweetLib.Classes.Exception;

namespace SweetLib.Classes.Storer
{
    public class RegistryStorer : IStorer
    {
        public RegistryKey BaseRegistryKey { get; }

        public RegistryStorer(string appName) : this(Registry.CurrentUser, appName) { }

        public RegistryStorer(RegistryKey baseRegistryKey, string appName)
        {
            baseRegistryKey = baseRegistryKey.CreateSubKey("SOFTWARE");
            BaseRegistryKey = baseRegistryKey?.CreateSubKey(appName);

            if (BaseRegistryKey == null)
                throw new RegistryStorerException("Unable to create registriy key.");
        }

        public string ReadString(string section, string key, string defaultValue = "")
        {
            var localRegKey = BaseRegistryKey.OpenSubKey(section);
            return (string)localRegKey?.GetValue(key.ToUpper());
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
            var localRegKey = BaseRegistryKey.CreateSubKey(section);
            localRegKey?.SetValue(key.ToUpper(), value);
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
            var localRegKey = BaseRegistryKey.CreateSubKey(section);
            localRegKey?.DeleteValue(key);
        }

        public void DeleteSection(string section)
        {
            BaseRegistryKey.DeleteSubKey(section);
        }
    }
}
