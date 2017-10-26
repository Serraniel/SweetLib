using Microsoft.Win32;
using SweetLib.Classes.Exceptions;

namespace SweetLib.Classes.Storer
{
    /// <summary>
    /// Implementation of an <see cref="IStorer"/> interface which stores the data inside the registry. 
    /// </summary>
    /// <remarks>
    /// Sections will be interpreted as subkeys on registry level.
    /// </remarks>
    public class RegistryStorer : IStorer
    {
        /// <summary>
        /// The base registry key in which will be operated.
        /// </summary>
        public RegistryKey OperatingRegistryKey { get; }

        /// <summary>
        /// Creates a new instance of <see cref="RegistryStorer"/> with a specified application name.
        /// </summary>
        /// <param name="appName">The applications base name. This will be used as name for a sub key inside the software key below the base key.</param>
        /// <remarks>
        /// This will use current user as the base key.
        /// </remarks>
        public RegistryStorer(string appName) : this(Registry.CurrentUser, appName) { }

        /// <summary>
        /// Creates a new instance of <see cref="RegistryStorer"/> with a specified application name.
        /// </summary>
        /// <param name="baseRegistryKey">Provide a key of <see cref="Registry"/>, e.G. <i>Registry.CurrentUser</i>.</param>
        /// <param name="appName">The applications base name. This will be used as name for a sub key inside the software key below the base key.</param>
        public RegistryStorer(RegistryKey baseRegistryKey, string appName)
        {
            baseRegistryKey = baseRegistryKey.CreateSubKey("SOFTWARE");
            OperatingRegistryKey = baseRegistryKey?.CreateSubKey(appName);

            if (OperatingRegistryKey == null)
                throw new RegistryStorerException("Unable to create registriy key.");
        }

        public string ReadString(string section, string key, string defaultValue = "")
        {
            var localRegKey = OperatingRegistryKey.OpenSubKey(section);
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
            var localRegKey = OperatingRegistryKey.CreateSubKey(section);
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
            var localRegKey = OperatingRegistryKey.CreateSubKey(section);
            localRegKey?.DeleteValue(key);
        }

        public void DeleteSection(string section)
        {
            OperatingRegistryKey.DeleteSubKey(section);
        }
    }
}
