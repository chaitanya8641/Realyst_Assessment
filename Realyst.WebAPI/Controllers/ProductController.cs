using Microsoft.AspNetCore.Mvc;
using Realyst.Application.Contracts;
using Realyst.Common;
using Realyst.Core.Models.Product;

namespace Realyst.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<ResponseModel>> GetProductsList()
        {
            IList<ProductModel> result = await _productService.GetProductsList();
            return ResponseUtility.CreateResponse(result);
        }
        [HttpPost("[action]")]
        public async Task<ActionResult<ResponseModel>> GetProductByProductId([FromBody] ProductByIdModel model)
        {
            var result = await _productService.GetProductByProductId(model);
            return ResponseUtility.CreateResponse(result);
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<ResponseModel>> AddProduct([FromBody] AddProductModel model)
        {
            var result = await _productService.AddProduct(model);
            return ResponseUtility.CreateResponse(result);
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<ResponseModel>> UpdateProduct([FromBody] UpdateProductModel model)
        {
            var result = await _productService.UpdateProduct(model);
            return ResponseUtility.CreateResponse(result);
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<ResponseModel>> DeleteProduct([FromBody] ProductByIdModel model)
        {
            var result = await _productService.DeleteProduct(model);
            return ResponseUtility.CreateResponse(result);
        }
    }
}
