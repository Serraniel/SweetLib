using System.Data.Common;
using MySqlConnector;

namespace SweetLib.Storage.MySql.Helper;

public static class MySqlDbParameterExtensions
{
    public static MySqlParameter AddMySqlParameterWithValue(this DbParameterCollection parameterCollection,
        string name, object value)
    {
        var param = new MySqlParameter(name, value);
        parameterCollection.Add(param);

        return param;
    }
}