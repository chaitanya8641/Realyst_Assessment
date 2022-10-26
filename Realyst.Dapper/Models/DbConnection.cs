
namespace Realyst.Dapper.Models
{
    public class DbConnection
    {
        public string ConnectionString { get; set; } = null!;
        public string StoredProcedure { get; set; } = null!;
        public object? Parameters { get; set; }
    }
}
