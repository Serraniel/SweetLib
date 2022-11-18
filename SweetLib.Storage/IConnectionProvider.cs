using System.Data;

namespace SweetLib.Storage
{
    /// <summary>
    ///     Provider for database connection.
    /// </summary>
    public interface IConnectionProvider<out T> where T : IDbConnection
    {
        /// <summary>
        ///     Gets an instance of a database connection.
        /// </summary>
        /// <returns></returns>
        T GetConnection();
    }
}