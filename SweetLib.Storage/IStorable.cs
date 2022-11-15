using System.Threading.Tasks;

namespace SweetLib.Storage
{
    /// <summary>
    ///     Interface for objects which can be stored and restored.
    /// </summary>
    /// <typeparam name="T">Type of the used identifier.</typeparam>
    public interface IStorable<T> : IIdentified<T>
    {
        /// <summary>
        ///     Stores the object.
        /// </summary>
        /// <returns></returns>
        Task Store();

        /// <summary>
        ///     Restores an object.
        /// </summary>
        /// <param name="identifier">Identifier of the object to restore.</param>
        /// <returns></returns>
        Task<bool> Restore(T identifier);

        /// <summary>
        ///     Determines whether the current object instance is new or already exists.
        /// </summary>
        /// <returns>Boolean indicating if the current object instance is new or already exists.</returns>
        bool IsNew();
    }
}