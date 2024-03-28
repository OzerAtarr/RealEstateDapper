using RealEstateDapper.API.DTOs.BottomGridDtos;

namespace RealEstateDapper.API.Repositories.BottomGridRepository
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
        Task<GetBottomGridDto> GetBottomGrid(int id);
        void CreateBottomGrid(CreateBottomGridDto createBottomGridDto);
        void DeleteBottomGrid(int id);
        void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto);
    }
}
