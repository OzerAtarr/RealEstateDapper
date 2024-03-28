using RealEstateDapper.API.DTOs.WhoWeAreDetailDtos;

namespace RealEstateDapper.API.Repositories.WhoWeAreDetailRepository
{
    public interface IWhoWeAreDetailRepository
    {
        Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync();
        Task<GetByIDWhoWeAreDetailDto> GetWhoWeAreDetail(int id);
        void CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto);
        void DeleteWhoWeAreDetail(int id);
        void UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto);
    }
}
