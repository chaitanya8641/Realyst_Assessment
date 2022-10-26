using Realyst.Dapper.Models;

namespace Realyst.Dapper.Contracts
{
    public interface IDapperRepository
    {
        Task<T> QueryOne<T>(DbConnection connection) where T : new();
        Task<IList<T>> QueryList<T>(DbConnection connection) where T : new();
        Task<int> Execute(DbConnection connection);
    }
}
