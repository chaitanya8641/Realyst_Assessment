using Realyst.Core.Models.Product;

namespace Realyst.Application.Contracts
{
    public interface IProductService
    {
        Task<IList<ProductModel>> GetProductsList();
        Task<ProductModel> GetProductByProductId(ProductByIdModel model);
        Task<int> AddProduct(AddProductModel model);
        Task<int> UpdateProduct(UpdateProductModel model);
        Task<int> DeleteProduct(ProductByIdModel model);

    }
}
