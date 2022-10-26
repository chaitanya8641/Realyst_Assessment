using Dapper;
using Realyst.Dapper.Contracts;
using Realyst.Dapper.Models;
using System.Data;
using System.Data.SqlClient;

namespace Realyst.Dapper.Services
{
    public class DapperRepository : IDapperRepository
    {
        public Task<int> Execute(DbConnection connection)
        {
            try
            {
                using (var conn = CreateConnection(connection.ConnectionString))
                {
                    return Task.FromResult(conn.Query<int>(connection.StoredProcedure, connection.Parameters, null, true, null,
                        CommandType.StoredProcedure).FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public Task<IList<T>> QueryList<T>(DbConnection connection) where T : new()
        {
            try
            {
                using (var conn = CreateConnection(connection.ConnectionString))
                {
                    IList<T> result = conn.Query<T>(connection.StoredProcedure, connection.Parameters, null, true, null,
                        CommandType.StoredProcedure).ToList();
                    return Task.FromResult(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<T> QueryOne<T>(DbConnection connection) where T : new()
        {
            try
            {
                using (var conn = CreateConnection(connection.ConnectionString))
                {
                    return Task.FromResult(conn.Query<T>(connection.StoredProcedure, connection.Parameters, null, true, null,
                        CommandType.StoredProcedure).FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static IDbConnection CreateConnection(string connectionString)
        {
            return new SqlConnection(connectionString);
        }
    }
}
