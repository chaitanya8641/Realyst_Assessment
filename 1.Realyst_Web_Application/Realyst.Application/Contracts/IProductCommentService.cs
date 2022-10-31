using Realyst.Core.Models.ProductComment;


namespace Realyst.Application.Contracts
{
    public interface IProductCommentService
    {
        Task<IList<GetProductCommentList>> GetProductCommentsListByProductId(ProductCommentsByProductId productId);
        Task<int> AddProductComment(AddProductCommentModel model);
    }
}
