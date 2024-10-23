using RealEstateDapper.API.DTOs.CategoryDtos;
using RealEstateDapper.API.DTOs.SubFeatureDtos;

namespace RealEstateDapper.API.Repositories.SubFatureRepositories
{
    public interface ISubFeatureRepository
    {
        Task<List<ResultSubFeatureDto>> GetAllSubFeatureAsync();
        Task<GetByIDCategoryDto> GetSubFeature(int id);
        Task CreateSubFeature(CreateSubFeatureDto createSubFeatureDto);
        Task DeleteSubFeature(int id);
        Task UpdateSubFeature(UpdateSubFeatureDto updateSubFeatureDto);
    }
}
