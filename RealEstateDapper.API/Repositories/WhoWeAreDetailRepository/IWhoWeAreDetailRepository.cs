using RealEstateDapper.API.DTOs.WhoWeAreDetailDtos;

namespace RealEstateDapper.API.Repositories.WhoWeAreDetailRepository
{
    public interface IWhoWeAreDetailRepository
    {
        Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync();
        Task<GetByIDWhoWeAreDetailDto> GetWhoWeAreDetail(int id);
        Task CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto);
        Task DeleteWhoWeAreDetail(int id);
        Task UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto);
    }
}
