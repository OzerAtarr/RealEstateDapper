using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper.API.Repositories.EstateAgentRepositories.DashbordRepositories.LastProductsRepositories;

namespace RealEstateDapper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentLastProductsController : ControllerBase
    {
        private readonly ILast5ProductsRepository _last5ProductsRepository;
        public EstateAgentLastProductsController(ILast5ProductsRepository last5ProductsRepository)
        {
            _last5ProductsRepository = last5ProductsRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int id) 
        {
            var values = await _last5ProductsRepository.GetLast5ProductByEmployeeIdAsync(id);
            return Ok(values);
        }
    }
}
