using System.Data.Common;

namespace SweetLib.Storage.Database
{
    /// <summary>
    ///     Provider for database connection.
    /// </summary>
    /// <typeparam name="T">Specific type of the database connection. Must inherit <see cref="DbConnection" />.</typeparam>
    public interface IConnectionProvider<T> where T : DbConnection
    {
        /// <summary>
        ///     Gets an instance of a database connection.
        /// </summary>
        /// <returns></returns>
        T GetConnection();
    }
}