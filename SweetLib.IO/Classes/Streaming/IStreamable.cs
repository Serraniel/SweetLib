using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SweetLib.IO.Classes.Streaming
{
    /// <summary>
    /// Streamable objects
    /// </summary>
    public interface IStreamable
    {
        /// <summary>
        /// Saves the current object into a stream.
        /// </summary>
        /// <param name="stream">Stream in which the current object should be saved.</param>
        void SaveToStream(Stream stream);
        
        /// <summary>
        /// Loads the object from a given stream.
        /// </summary>
        /// <param name="stream">Stream from which the object is loaded.</param>
        void LoadFromStream(Stream stream);
    }
}
