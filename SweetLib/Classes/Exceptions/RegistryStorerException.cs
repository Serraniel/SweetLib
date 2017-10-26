using SweetLib.Classes.Storer;

namespace SweetLib.Classes.Exceptions
{
    /// <summary>
    /// Exception thrown by <see cref="RegistryStorer"/>.
    /// </summary>
    public class RegistryStorerException : System.Exception
    {
        /// <summary>
        /// Creates a new <see cref="RegistryStorerException"/>.
        /// </summary>
        public RegistryStorerException() { }

        /// <summary>
        /// Creates a new <see cref="RegistryStorerException"/>.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public RegistryStorerException(string message) : base(message) { }
    }
}
