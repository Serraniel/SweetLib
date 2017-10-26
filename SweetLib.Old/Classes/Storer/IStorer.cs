namespace SweetLib.Classes.Storer
{
    /// <summary>
    /// Interface, which provides several methods to store simple data.
    /// </summary>
    public interface IStorer
    {
        /// <summary>
        /// Reads a string value.
        /// </summary>
        /// <param name="section">Represents the section in which the data is stored.</param>
        /// <param name="key">Represents the key of the stored data.</param>
        /// <param name="defaultValue">Default value, if this value does not exist.</param>
        /// <returns>Value of the <see cref="key"/> in <see cref="section"/>.</returns>
        string ReadString(string section, string key, string defaultValue = "");

        /// <summary>
        /// Reads an integer value.
        /// </summary>
        /// <param name="section">Represents the section in which the data is stored.</param>
        /// <param name="key">Represents the key of the stored data.</param>
        /// <param name="defaultValue">Default value, if this value does not exist.</param>
        /// <returns>Value of the <see cref="key"/> in <see cref="section"/>.</returns>
        int ReadInteger(string section, string key, int defaultValue = 0);

        /// <summary>
        /// Reads a bool value.
        /// </summary>
        /// <param name="section">Represents the section in which the data is stored.</param>
        /// <param name="key">Represents the key of the stored data.</param>
        /// <param name="defaultValue">Default value, if this value does not exist.</param>
        /// <returns>Value of the <see cref="key"/> in <see cref="section"/>.</returns>
        bool ReadBool(string section, string key, bool defaultValue = false);

        /// <summary>
        /// Checks, if a key exists inside a section.
        /// </summary>
        /// <param name="section">Represents the section in which the data is stored.</param>
        /// <param name="key">Represents the key of the stored data.</param>
        /// <returns>True, if <see cref="key"/> is found inside <see cref="section"/>.</returns>
        bool HasKey(string section, string key);

        /// <summary>
        /// Writes a string value.
        /// </summary>
        /// <param name="section">Represents the section in which the data is stored.</param>
        /// <param name="key">Represents the key of the stored data.</param>
        /// <param name="value">Value to be stored.</param>
        void WriteString(string section, string key, string value);

        /// <summary>
        /// Writes an integer value.
        /// </summary>
        /// <param name="section">Represents the section in which the data is stored.</param>
        /// <param name="key">Represents the key of the stored data.</param>
        /// <param name="value">Value to be stored.</param>
        void WriteInteger(string section, string key, int value);

        /// <summary>
        /// Writes a bool value.
        /// </summary>
        /// <param name="section">Represents the section in which the data is stored.</param>
        /// <param name="key">Represents the key of the stored data.</param>
        /// <param name="value">Value to be stored.</param>
        void WriteBool(string section, string key, bool value);

        /// <summary>
        /// Deletes a key inside a <see cref="section"/>.
        /// </summary>
        /// <param name="section">Represents the section in which the data is stored.</param>
        /// <param name="key">Represents the key to be deleted.</param>
        void DeleteKey(string section, string key);

        /// <summary>
        /// Deletes a section with all its keys.
        /// </summary>
        /// <param name="section">Represents the section to be deleted.</param>
        void DeleteSection(string section);
    }
}
