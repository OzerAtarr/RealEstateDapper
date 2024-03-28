using RealEstateDapper.API.DTOs.CategoryDtos;

namespace RealEstateDapper.API.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        Task<GetByIDCategoryDto> GetCategory(int id);
        void CreateCategory(CreateCategoryDto categoryDto);
        void DeleteCategory(int id);
        void UpdateCategory(UpdateCategoryDto updateCategoryDto);
    }
}
