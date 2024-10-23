using RealEstateDapper.API.DTOs.BottomGridDtos;

namespace RealEstateDapper.API.Repositories.BottomGridRepository
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
        Task<GetBottomGridDto> GetBottomGrid(int id);
        Task CreateBottomGrid(CreateBottomGridDto createBottomGridDto);
        Task DeleteBottomGrid(int id);
        Task UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto);
    }
}
