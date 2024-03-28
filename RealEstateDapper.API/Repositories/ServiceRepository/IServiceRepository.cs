using RealEstateDapper.API.DTOs.ServiceDtos;

namespace RealEstateDapper.API.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        Task<GetByIDServiceDto> GetService(int id);
        void CreateService(CreateServiceDto createServiceDto);
        void DeleteService(int id);
        void UpdateService(UpdateServiceDto updateServiceDto);
    }
}
