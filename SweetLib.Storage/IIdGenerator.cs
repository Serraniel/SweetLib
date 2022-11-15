using System.Threading.Tasks;

namespace SweetLib.Storage
{
    /// <summary>
    ///     Generates a new object id.
    /// </summary>
    /// <typeparam name="T">Type of the used identifier.</typeparam>
    public interface IIdGenerator<T>
    {
        /// <summary>
        ///     Generates a new id of the specified type.
        /// </summary>
        /// <returns></returns>
        T GenerateNewId();

        /// <summary>
        ///     Generates a new id of the specified type. Runs asynchronous.
        /// </summary>
        /// <returns></returns>
        Task<T> GenerateNewIdAsync();
    }
}