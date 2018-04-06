using System.IO;

namespace SweetLib.IO.Classes.Streaming
{
    /// <summary>
    /// Exception thrown by streaming related operations.
    /// </summary>
    public class StreamException : IOException
    {
        /// <summary>
        /// Creates a new <see cref="StreamException"/>.
        /// </summary>
        public StreamException() { }

        /// <summary>
        /// Creates a new <see cref="StreamException"/>.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public StreamException(string message) : base(message) { }
    }

    /// <summary>
    /// Exception thrown by streaming related operations. May be thrown if the stream types do not match.
    /// </summary>
    public class StreamTypeException : StreamException
    {
        /// <summary>
        /// Creates a new <see cref="StreamTypeException"/>.
        /// </summary>
        public StreamTypeException() { }

        /// <summary>
        /// Creates a new <see cref="StreamTypeException"/>.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public StreamTypeException(string message) : base(message) { }
    }
}
