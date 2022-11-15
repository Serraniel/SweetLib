using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SweetLib.Storage.Database;
using SweetLib.Storage.MySql.Helper;

namespace SweetLib.Storage.MySql;

public abstract class CustomMySqlObject<T> : IDatabaseObject<T>
{
    protected CustomMySqlObject(IConnectionProvider<MySqlConnection> connectionProvider,
        IIdGenerator<T> idGenerator)
    {
        ConnectionProvider = connectionProvider;
        IdGenerator = idGenerator;
        Id = UnidentifiedId();
    }

    protected IConnectionProvider<MySqlConnection> ConnectionProvider { get; }
    protected IIdGenerator<T> IdGenerator { get; }

    public T Id { get; set; }
    public abstract T UnidentifiedId();

    public async Task Store()
    {
        var wasNew = IsNew();

        var connection = ConnectionProvider!.GetConnection();
        await connection.OpenAsync();
        try
        {
            var command = connection.CreateCommand();
            try
            {
                command.CommandText = wasNew ? InsertCommand() : UpdateCommand();
                await AssignToAsync(command.Parameters);
                await command.ExecuteNonQueryAsync();
            }
            catch
            {
                // Avoid invalid ID if new object could not be stored
                if (wasNew)
                    Id = UnidentifiedId();

                throw;
            }
        }
        finally
        {
            await connection.CloseAsync();
        }
    }

    public bool IsNew()
    {
        return Id.Equals(UnidentifiedId());
    }

    public IEnumerable<string> AssignFieldNames()
    {
        var result = new List<string>();
        result.Add(IdFieldName());

        return result;
    }

    public async Task AssignToAsync(DbParameterCollection parameters)
    {
        if (IsNew()) Id = await IdGenerator.GenerateNewIdAsync();

        parameters.AddMySqlParameterWithValue("@Id", Id);
    }

    public async Task AssignFromAsync(DbDataReader reader)
    {
        Id = (T)reader["Id"];
    }

    public abstract string TableName();

    public async Task<bool> Restore(T identifier)
    {
        var connection = ConnectionProvider!.GetConnection();
        await connection.OpenAsync();
        try
        {
            var command = connection.CreateCommand();
            command.CommandText = $"SELECT * FROM {TableName()} WHERE Id=@id";
            command.Parameters.AddWithValue("@id", identifier);

            var reader = await command.ExecuteReaderAsync();
            if (!reader.HasRows)
                return false;

            await AssignFromAsync(reader);
            return true;
        }
        finally
        {
            await connection.CloseAsync();
        }
    }

    internal string InsertCommand()
    {
        var fields = AssignFieldNames();
        return
            $"INSERT INTO {TableName()} ({string.Join(",", fields)}) VALUES ({string.Join(",", fields.Select(f => $"@{f}"))})";
    }

    internal string UpdateCommand()
    {
        var fields = AssignFieldNames();
        return $"UPDATE {TableName()} SET {string.Join(",", fields.Select(f => $"{f}=@{f}"))}";
    }

    public abstract string IdFieldName();
}