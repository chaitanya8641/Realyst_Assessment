using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realyst.Dapper.Models
{
    public class DbRequest<T> where T : new()
    {
        public DbConnection DbConnection { get; set; } = new DbConnection();
        public T? Item { get; set; }
    }
}
