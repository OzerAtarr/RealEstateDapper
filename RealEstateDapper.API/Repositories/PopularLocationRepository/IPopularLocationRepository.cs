using RealEstateDapper.API.DTOs.PopularLocationDtos;

namespace RealEstateDapper.API.Repositories.PopularLocationRepository
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
        Task<GetPopularLocationDto> GetPopularLocation(int id);
        void CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto);
        void DeletePopularLocation(int id);
        void UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto);
    }
}
