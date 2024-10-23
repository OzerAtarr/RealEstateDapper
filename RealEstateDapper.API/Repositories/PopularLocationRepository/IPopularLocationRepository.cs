using RealEstateDapper.API.DTOs.PopularLocationDtos;

namespace RealEstateDapper.API.Repositories.PopularLocationRepository
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
        Task<GetPopularLocationDto> GetPopularLocation(int id);
        Task CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto);
        Task DeletePopularLocation(int id);
        Task UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto);
    }
}
