using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper.API.Repositories.PropertyAmenityRepositories;

namespace RealEstateDapper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyAmenitiesController : ControllerBase
    {
        private readonly IPropertyAmenityRepository _propertyAmenityRepository;
        public PropertyAmenitiesController(IPropertyAmenityRepository propertyAmenityRepository)
        {
            _propertyAmenityRepository = propertyAmenityRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetPropertyAmenityByStatusTrue(int id)
        {
            var value = await _propertyAmenityRepository.GetPropertyAmenityByStatusTrue(id);
            return Ok(value);
        }

    }
}
