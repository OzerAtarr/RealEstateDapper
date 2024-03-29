using Microsoft.AspNetCore.Mvc;
using RealEstateDapper.API.DTOs.TestimonialDtos;
using RealEstateDapper.API.Repositories.TestimonialRepository;

namespace RealEstateDapper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialRepository _testimonialRepository;
        public TestimonialsController(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }


        [HttpGet]
        public async Task<IActionResult> TestimonialList()
        {
            var value = await _testimonialRepository.GetAllTestimonialAsync();
            return Ok(value);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonial(int id)
        {
            var value = await _testimonialRepository.GetTestimonial(id);
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            _testimonialRepository.CreateTestimonial(createTestimonialDto);
            return Ok("Referans başarıyla eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testimonialRepository.UpdateTestimonial(updateTestimonialDto);
            return Ok("Referans başarıyla güncellendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            _testimonialRepository.DeleteTestimonial(id);
            return Ok("Referans başarıyla silindi.");
        }
    }
}
