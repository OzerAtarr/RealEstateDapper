using RealEstateDapper.API.DTOs.ServiceDtos;

namespace RealEstateDapper.API.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        Task<GetByIDServiceDto> GetService(int id);
        Task CreateService(CreateServiceDto createServiceDto);
        Task DeleteService(int id);
        Task UpdateService(UpdateServiceDto updateServiceDto);
    }
}
