using RealEstateDapper.API.DTOs.CategoryDtos;
using RealEstateDapper.API.DTOs.EmployeeDtos;

namespace RealEstateDapper.API.Repositories.EmplyeeRepository
{
    public interface IEmplyeeRepository
    {
        Task<List<ResultEmployeeDto>> GetAllEmployeeAsync();
        Task<GetByIDEmployeeDto> GetEmployee(int id);
        void CreateteEmployee(CreateEmployeeDto createEmployeeDto);
        void DeleteteEmployee(int id);
        void UpdateteEmployee(UpdateEmployeeDto updateEmployeeDto);
    }
}
