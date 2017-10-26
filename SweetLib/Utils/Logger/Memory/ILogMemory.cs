using SweetLib.Utils.Logger.Message;

namespace SweetLib.Utils.Logger.Memory
{
    /// <summary>
    /// Interface for a class to store and proceed <see cref="LogMessage"/> objects. 
    /// </summary>
    public interface ILogMemory
    {
        /// <summary>
        /// Adds a <see cref="message"/> into the <see cref="ILogMemory"/>.
        /// </summary>
        /// <param name="message"><see cref="LogMessage"/> to be stored.</param>
        void Remember(LogMessage message);

        /// <summary>
        /// Removes a <see cref="message"/> from the <see cref="ILogMemory"/>.
        /// </summary>
        /// <param name="message"><see cref="LogMessage"/> to be removed.</param>
        /// <remarks>This might not have any effect depending on the <see cref="ILogMemory"/> implementation.</remarks>
        void Forget(LogMessage message);

        /// <summary>
        /// Saves all remembered <see cref="LogMessage"/> objects into a persistent file.
        /// </summary>
        /// <param name="fullFileName">File name to store the <see cref="LogMessage"/> objects.</param>
        void Archive(string fullFileName);
    }
}
