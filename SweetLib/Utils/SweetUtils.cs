using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetLib.Utils
{
    /// <summary>
    /// A generic class containing useful methods.
    /// </summary>
    public static class SweetUtils
    {
        public static char DefaultFileNameReplaceChar { get; set; } = '-';

        /// <summary>
        /// Legalizes a file name with the <see cref="DefaultFileNameReplaceChar"/> character.
        /// </summary>
        /// <param name="fileName">File name to legalize.</param>
        /// <returns>Legalized file name.</returns>
        public static string LegalizeFilename(string fileName)
        {
            return LegalizeFilename(fileName, '-');
        }

        /// <summary>
        /// Legalizes a file name by a given replace character.
        /// </summary>
        /// <param name="fileName">File name to legalize.</param>
        /// <param name="replaceChar">Character to be used as replace character.</param>
        /// <returns>Legalized file name.</returns>
        public static string LegalizeFilename(string fileName, char replaceChar)
        {
            var invalidChars = System.IO.Path.GetInvalidFileNameChars();

            if(invalidChars.Contains(replaceChar))
                throw new IOException($"Replace character {replaceChar} is an invalid file name character.");

            return invalidChars.Aggregate(fileName, (current, c) => current.Replace(c, replaceChar));
        }
    }
}
