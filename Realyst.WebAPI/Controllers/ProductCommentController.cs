using Microsoft.AspNetCore.Mvc;
using Realyst.Application.Contracts;
using Realyst.Common;
using Realyst.Core.Models.ProductComment;

namespace Realyst.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCommentController : ControllerBase
    {
        private readonly IProductCommentService _productCommentService;
        public ProductCommentController(IProductCommentService productCommentService)
        {
            _productCommentService = productCommentService;
        }


        [HttpPost("[action]")]
        public async Task<ActionResult<ResponseModel>> GetProductCommentsList([FromBody] ProductCommentsByProductId model)
        {
            IList<ProductCommentModel> result = await _productCommentService.GetProductCommentsListByProductId(model);
            return ResponseUtility.CreateResponse(result);
        }


        [HttpPost("[action]")]
        public async Task<ActionResult<ResponseModel>> AddProductComment([FromBody] AddProductCommentModel model)
        {
            var result = await _productCommentService.AddProductComment(model);
            return ResponseUtility.CreateResponse(result);
        }
    }
}
