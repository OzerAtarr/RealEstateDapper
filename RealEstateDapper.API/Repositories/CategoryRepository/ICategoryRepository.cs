using RealEstateDapper.API.DTOs.CategoryDtos;

namespace RealEstateDapper.API.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task<GetByIDCategoryDto> GetCategory(int id);
        Task CreateCategory(CreateCategoryDto categoryDto);
        Task DeleteCategory(int id);
        Task UpdateCategory(UpdateCategoryDto updateCategoryDto);
    }
}
