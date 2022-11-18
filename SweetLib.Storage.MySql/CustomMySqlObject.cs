using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using SweetLib.Storage.Database;
using SweetLib.Storage.MySql.Helper;

namespace SweetLib.Storage.MySql;

public abstract class CustomMySqlObject<T> : IDatabaseObject<T>
{
    protected CustomMySqlObject(IDatabaseConnectionProvider connectionProvider,
        IIdGenerator<T> idGenerator)
    {
        ConnectionProvider = connectionProvider;
        IdGenerator = idGenerator;
        Id = UnidentifiedId();
    }

    protected IDatabaseConnectionProvider ConnectionProvider { get; }
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
            connection.Close();
        }
    }

    public bool IsNew()
    {
        return Id.Equals(UnidentifiedId());
    }

    public virtual IEnumerable<string> AssignFieldNames()
    {
        var result = new List<string>();
        result.Add(IdFieldName());

        return result;
    }

    public virtual async Task AssignToAsync(DbParameterCollection parameters)
    {
        if (IsNew()) Id = await IdGenerator.GenerateNewIdAsync();

        parameters.AddMySqlParameterWithValue("@Id", Id);
    }

    public virtual async Task AssignFromAsync(DbDataReader reader)
    {
        await reader.ReadAsync();
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
            command.Parameters.AddMySqlParameterWithValue("@id", identifier);

            var reader = await command.ExecuteReaderAsync();
            if (!reader.HasRows)
                return false;

            await AssignFromAsync(reader);
            return true;
        }
        finally
        {
            connection.Close();
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