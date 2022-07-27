




/// <summary>
/// Class for write data in Database 
/// </summary>
/// 
/// 
/// <class costractor >
/// Injection from Iconfiguration  
/// </class>
/// 
/// 
/// 
/// <class ExecuteAsync>
/// <summary>
/// Class that execute sql command and return key value.
/// </summary>
/// <param name="sql">
/// The sql which contains the Sql Command.
/// sql cann't be null.
/// </param>
/// 
/// <param name="param">
/// The param which contains the Sql Commands parameter.
/// pram can be null.
/// </param>
/// 
/// <param name="transaction">
/// Database transaction control.
/// </param>
/// 
/// </class>


/// <class QueryAsync>
/// <summary>
/// Class that returns IEnumerable list of generic type.
/// </summary>

/// </class>
/// 


/// <class QueryFirstOrDefaultAsync>
/// <summary>
/// Class that execute sql command and returns a record as the result.if there is no result returns the default value. 
/// </summary>
/// </class>
/// 


/// <class QuerySingleAsync>
/// <summary>
/// Class that execute sql command and  returns a record as the result. 
/// </summary>
/// </class>
/// 

/// <class Dispose>
/// <summary>
/// Class that dispose connection.
/// </summary>


/// </class>




using Dapper;
using Domain.Interfaces.Database;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DataAcess.Connection
{
    public class ApplicationWriteDbConnection : IApplicationWriteToDb, IDisposable
    {

        private readonly IDbConnection connection;
        public ApplicationWriteDbConnection(IConfiguration configuration)
        {
            connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public async Task<int> ExecuteAsync(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default)
        {
            return await connection.ExecuteAsync(sql, param, transaction);
        }
        public async Task<List<T>> QueryAsync<T>(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default)
        {
            return (await connection.QueryAsync<T>(sql, param, transaction)).AsList();
        }
        public async Task<T> QueryFirstOrDefaultAsync<T>(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default)
        {
            return await connection.QueryFirstOrDefaultAsync<T>(sql, param, transaction);
        }
        public async Task<T> QuerySingleAsync<T>(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default)
        {
            return await connection.QuerySingleAsync<T>(sql, param, transaction);
        }
        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
