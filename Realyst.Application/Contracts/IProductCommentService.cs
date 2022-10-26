using Realyst.Core.Models.ProductComment;


namespace Realyst.Application.Contracts
{
    public interface IProductCommentService
    {
        Task<IList<ProductCommentModel>> GetProductCommentsListByProductId(ProductCommentsByProductId productId);
        Task<int> AddProductComment(AddProductCommentModel model);
    }
}
