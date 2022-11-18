using System.Data.Common;

namespace SweetLib.Storage.Database
{
    public interface IDatabaseConnectionProvider : IConnectionProvider<DbConnection>
    {
    }
}