using Microsoft.Extensions.Configuration;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.DbAccess;
public class SqlDataAccess : ISqlDataAccess//Talking to our DataBase
{
    private readonly IConfiguration _config; //a private readonly field _config of type IConfiguration for storing configuration values

	public SqlDataAccess(IConfiguration config) //a constructor that takes an IConfiguration parameter for injecting configuration values
	{
        _config = config;// Assigning the injected configuration to the _config field
	}
    public async Task<IEnumerable<T>> LoadData<T, U>(
        string storedProcedure,
        U parameters,
        string connectionId = "Default")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));
		//a new SqlConnection object using the connection string retrieved from the configuration, and assigning it to the connection variable
		//the 'using' block ensures that the connection is properly disposed of when the block is exited
		//the returned connection implements the IDbConnection interface, which is used to abstract away the implementation details of different database providers

		return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
		//Using Dapper's QueryAsync method to asynchronously execute the stored procedure with the provided parameters and return the results as an IEnumerable<T> object
		//the 'commandType' parameter specifies that the command is a stored procedure
	}
	public async Task SaveData<T>(
        string storedProcedure,
        T parameters,
        string connectionId = "Default")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

        await connection.ExecuteAsync(storedProcedure, parameters,
            commandType: CommandType.StoredProcedure);
    }
}