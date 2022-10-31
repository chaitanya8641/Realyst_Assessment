using Microsoft.Extensions.Configuration;
using Realyst.Dapper.Contracts;

namespace Realyst.Dapper.Models
{
    public class RepositoryBase
    {
        public IDapperRepository _dapperRepository;
        public DbConnection _dbconnection { get; set; } = new DbConnection();

        public IConfiguration _configuration;
        public RepositoryBase(IDapperRepository dapperRepository, IConfiguration configuration)
        {
            _dapperRepository = dapperRepository;
            _configuration = configuration;
            _dbconnection.ConnectionString = configuration.GetConnectionString("RealystDB");
        }
    }
}
