using Microsoft.Extensions.Configuration;
using Realyst.Application.Contracts;
using Realyst.Common;
using Realyst.Core.Models.Product;
using Realyst.Dapper.Contracts;
using Realyst.Dapper.Models;

namespace Realyst.Infrastructure.Services
{
    public class ProductService : RepositoryBase, IProductService
    {
        public ProductService(IDapperRepository dapperRepository, IConfiguration configuration) : base(dapperRepository, configuration)
        {

        }

        public async Task<IList<ProductModel>> GetProductsList()
        {
            try
            {
                _dbconnection.StoredProcedure = ContantStoredProcedure.GetProductsListStoredProcedure;
                _dbconnection.Parameters = null;
                return await _dapperRepository.QueryList<ProductModel>(_dbconnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ProductModel> GetProductByProductId(ProductByIdModel model)
        {
            try
            {
                _dbconnection.StoredProcedure = ContantStoredProcedure.GetProductByProductIdStoredProcedure;
                _dbconnection.Parameters = model;
                return await _dapperRepository.QueryOne<ProductModel>(_dbconnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> AddProduct(AddProductModel model)
        {
            try
            {
                _dbconnection.StoredProcedure = ContantStoredProcedure.AddProductStoredProcedure;
                _dbconnection.Parameters = model;
                return await _dapperRepository.Execute(_dbconnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> UpdateProduct(UpdateProductModel model)
        {
            try
            {
                _dbconnection.StoredProcedure = ContantStoredProcedure.UpdateProductStoredProcedure;
                _dbconnection.Parameters = model;
                return await _dapperRepository.Execute(_dbconnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> DeleteProduct(ProductByIdModel model)
        {
            try
            {
                _dbconnection.StoredProcedure = ContantStoredProcedure.DeleteProductStoredProcedure;
                _dbconnection.Parameters = model;
                return await _dapperRepository.Execute(_dbconnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
