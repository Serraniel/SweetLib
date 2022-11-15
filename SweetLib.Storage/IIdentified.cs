namespace SweetLib.Storage
{
    /// <summary>
    ///     Interface for identified objects.
    /// </summary>
    /// <typeparam name="T">Type of the identifier.</typeparam>
    public interface IIdentified<T>
    {
        /// <summary>
        ///     Identifier of the object.
        /// </summary>
        T Id { get; set; }

        /// <summary>
        ///     Gets a dummy Id for unidentified instances;
        /// </summary>
        /// <returns></returns>
        T UnidentifiedId();
    }
}