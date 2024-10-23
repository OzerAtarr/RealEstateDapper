using Microsoft.AspNetCore.Mvc;
using RealEstateDapper.API.DTOs.ProductDtos;
using RealEstateDapper.API.Repositories.ProductRepository;

namespace RealEstateDapper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productRepository.GetAllProductAsync();
            return Ok(values);
        }

        [HttpGet("ProductListWithCategory")]
        public async Task<IActionResult> ProductListWithCategory()
        {
            var values = await _productRepository.GetAllProductWithCategoryAsync();
            return Ok(values);
        }
        [HttpGet("ProductAdvertListByEmployeeByTrue")]
        public async Task<IActionResult> ProductAdvertListByEmployeeByTrue(int id)
        {
            var values = await _productRepository.GetProductAdvertListByEmployeeAsyncByTrue(id);
            return Ok(values);
        }
        [HttpGet("ProductAdvertListByEmployeeByFalse")]
        public async Task<IActionResult> ProductAdvertListByEmployeeByFalse(int id)
        {
            var values = await _productRepository.GetProductAdvertListByEmployeeAsyncByFalse(id);
            return Ok(values);
        }

        [HttpGet("ProductDealOfTheDayStatusChangeToTrue/{id}")]
        public async Task<IActionResult> ProductDealOfTheDayStatusChangeToTrue(int id)
        {
            _productRepository.ProductDealOfTheDayStatusChangeToTrue(id);
            return Ok("İlan Günün Fırsatları Arasına Eklendi");
        }

        [HttpGet("ProductDealOfTheDayStatusChangeToFalse/{id}")]
        public async Task<IActionResult> ProductDealOfTheDayStatusChangeToFalse(int id)
        {
            _productRepository.ProductDealOfTheDayStatusChangeToFalse(id);
            return Ok("İlan Günün Fırsatları Arasından Çıkarıldı");
        }

        [HttpGet("GetLast5ProductAsync")]
        public async Task<IActionResult> GetLast5ProductAsync()
        {
            var values = await _productRepository.GetLast5ProductAsync();
            return Ok(values);
        }

        [HttpGet("GetLast3ProductAsync")]
        public async Task<IActionResult> GetLast3ProductAsync()
        {
            var values = await _productRepository.GetLast3ProductAsync();
            return Ok(values);
        }

        [HttpPost("CreateProduct")]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            await _productRepository.CreateProduct(createProductDto);
            return Ok("İlan Oluşturuldu.");
        }

        [HttpGet("GetProductByProductId")]
        public async Task<IActionResult> GetProductByProductId(int id)
        {
            var value = await _productRepository.GetProductByProductId(id);
            return Ok(value);
        }

        [HttpGet("ResultProductWithSearchList")]
        public async Task<IActionResult> ResultProductWithSearchList(string searchKeyValue, int propertyCategoryId, string city)
        {
            var value = await _productRepository.ResultProductWithSearchList(searchKeyValue, propertyCategoryId, city);
            return Ok(value);
        }

		
		[HttpGet("GetProductByDealOfThDayTrueWithCategory")]
		public async Task<IActionResult> GetProductByDealOfThDayTrueWithCategory()
		{
			var value = await _productRepository.GetProductByDealOfThDayTrueWithCategoryAsync();
			return Ok(value);
		}
	}
}
