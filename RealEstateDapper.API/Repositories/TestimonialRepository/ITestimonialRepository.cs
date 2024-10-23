using RealEstateDapper.API.DTOs.TestimonialDtos;

namespace RealEstateDapper.API.Repositories.TestimonialRepository
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
        Task<GetByIDTestimonialDto> GetTestimonial(int id);
        Task CreateTestimonial(CreateTestimonialDto createTestimonialDto);
        Task DeleteTestimonial(int id);
        Task UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto);
    }
}
