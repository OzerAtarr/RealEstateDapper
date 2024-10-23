using RealEstateDapper.API.DTOs.AppUserDtos;

namespace RealEstateDapper.API.Repositories.AppUserRepositories
{
    public interface IAppUserRepository
    {
        Task<GetAppUserByProductIdDto> GetAppUserByProductId(int id);
    }
}
