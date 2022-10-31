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
        public async Task<ActionResult<DataTableResponse>> GetProductCommentsList([FromBody] ProductCommentsByProductId model)
        {
            IList<GetProductCommentList> result = await _productCommentService.GetProductCommentsListByProductId(model);
            return new DataTableResponse
            {
                RecordsTotal = result.Count,
                RecordsFiltered = 10,
                Data = result.ToArray()
            };
        }


        [HttpPost("[action]")]
        public async Task<ActionResult<ResponseModel>> AddProductComment([FromBody] AddProductCommentModel model)
        {
            var result = await _productCommentService.AddProductComment(model);
            return ResponseUtility.CreateResponse(result);
        }
    }
}
