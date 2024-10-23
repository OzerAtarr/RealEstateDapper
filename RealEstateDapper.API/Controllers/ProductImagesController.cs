using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper.API.Repositories.CategoryRepository;
using RealEstateDapper.API.Repositories.ProductImageRepositories;

namespace RealEstateDapper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImagesController : ControllerBase
    {
        private readonly IProductImageRepository _productImageRepository;
        public ProductImagesController(IProductImageRepository productImageRepository)
        {
            _productImageRepository = productImageRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductImageByProductId(int productId)
        {
            var values = await _productImageRepository.GetProductImageByProductId(productId);
            return Ok(values);
        }

    }
}
