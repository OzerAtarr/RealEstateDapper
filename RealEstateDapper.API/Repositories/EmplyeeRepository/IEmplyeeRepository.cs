using RealEstateDapper.API.DTOs.CategoryDtos;
using RealEstateDapper.API.DTOs.EmployeeDtos;

namespace RealEstateDapper.API.Repositories.EmplyeeRepository
{
    public interface IEmplyeeRepository
    {
        Task<List<ResultEmployeeDto>> GetAllEmployeeAsync();
        Task<GetByIDEmployeeDto> GetEmployee(int id);
        Task CreateteEmployee(CreateEmployeeDto createEmployeeDto);
        Task DeleteteEmployee(int id);
        Task UpdateteEmployee(UpdateEmployeeDto updateEmployeeDto);
    }
}
