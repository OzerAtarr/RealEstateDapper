using RealEstateDapper.API.DTOs.TestimonialDtos;

namespace RealEstateDapper.API.Repositories.TestimonialRepository
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
        Task<GetByIDTestimonialDto> GetTestimonial(int id);
        void CreateTestimonial(CreateTestimonialDto createTestimonialDto);
        void DeleteTestimonial(int id);
        void UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto);
    }
}
