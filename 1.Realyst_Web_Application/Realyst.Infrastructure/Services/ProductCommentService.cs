using Microsoft.Extensions.Configuration;
using Realyst.Application.Contracts;
using Realyst.Common;
using Realyst.Core.Models.ProductComment;
using Realyst.Dapper.Contracts;
using Realyst.Dapper.Models;

namespace Realyst.Infrastructure.Services
{
    public class ProductCommentService: RepositoryBase, IProductCommentService
    {
        public ProductCommentService(IDapperRepository dapperRepository, IConfiguration configuration) : base(dapperRepository, configuration)
        {

        }

        public async Task<int> AddProductComment(AddProductCommentModel model)
        {
            try
            {
                _dbconnection.StoredProcedure = ContantStoredProcedure.AddCommentStoredProcedure;
                _dbconnection.Parameters = model;
                return await _dapperRepository.Execute(_dbconnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<GetProductCommentList>> GetProductCommentsListByProductId(ProductCommentsByProductId model)
        {
            try
            {
                _dbconnection.StoredProcedure = ContantStoredProcedure.GetCommentsByProductIdStoredProcedure;
                _dbconnection.Parameters = model;
                return await _dapperRepository.QueryList<GetProductCommentList>(_dbconnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
