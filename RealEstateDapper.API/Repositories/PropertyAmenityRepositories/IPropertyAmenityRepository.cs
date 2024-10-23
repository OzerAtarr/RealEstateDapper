using RealEstateDapper.API.DTOs.PropertyAmenityDtos;

namespace RealEstateDapper.API.Repositories.PropertyAmenityRepositories
{
    public interface IPropertyAmenityRepository
    {
        Task<List<ResultPropertyAmenityByStatusTrueDto>> GetPropertyAmenityByStatusTrue(int id);
    }
}
