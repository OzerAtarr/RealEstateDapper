using Microsoft.AspNetCore.Mvc;
using RealEstateDapper.API.Repositories.EstateAgentRepositories.DashbordRepositories.StatisticRepositories;

namespace RealEstateDapper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentStatisticController : ControllerBase
    {
        private readonly IStatisticRepository _statisticRepository;
        public EstateAgentStatisticController(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        [HttpGet("AllProductCount")]
        public IActionResult AllProductCount()
        {
            return Ok(_statisticRepository.AllProductCount());
        }

        [HttpGet("ProductCountByStatusFalse")]
        public IActionResult ProductCountByStatusFalse(int id)
        {
            return Ok(_statisticRepository.ProductCountByStatusFalse(id));
        }

        [HttpGet("ProductCountByStatusTrue")]
        public IActionResult ProductCountByStatusTrue(int id)
        {
            return Ok(_statisticRepository.ProductCountByStatusTrue(id));
        }

        [HttpGet("ProductCountByEmployeeId")]
        public IActionResult ProductCountByEmployeeId(int id)
        {
            return Ok(_statisticRepository.ProductCountByEmployeeId(id));
        }
    }
}
