using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace SweetLib.Storage.Database
{
    /// <summary>
    ///     Object to store in database.
    /// </summary>
    /// <typeparam name="T">Type of the used identifier.</typeparam>
    public interface IDatabaseObject<T> : IStorable<T>
    {
        /// <summary>
        ///     Assigns field names of the database columns.
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> AssignFieldNames();

        /// <summary>
        ///     Assigns values to the query parameters.
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task AssignToAsync(DbParameterCollection parameters);

        /// <summary>
        ///     Assigns values to the object.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        Task AssignFromAsync(DbDataReader reader);

        /// <summary>
        ///     Table name of the object.
        /// </summary>
        /// <returns></returns>
        string TableName();
    }
}