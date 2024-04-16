using Microsoft.AspNetCore.Mvc;
using RealEstateDapper.API.DTOs.EmployeeDtos;
using RealEstateDapper.API.Repositories.EmplyeeRepository;

namespace RealEstateDapper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmplyeeRepository _emplyeeRepository;
        public EmployeesController(IEmplyeeRepository emplyeeRepository)
        {
            _emplyeeRepository = emplyeeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> EmployeeList()
        {
            var values = await _emplyeeRepository.GetAllEmployeeAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            _emplyeeRepository.CreateteEmployee(createEmployeeDto);
            return Ok("Personel Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            _emplyeeRepository.DeleteteEmployee(id);
            return Ok("Personel Başarılı Bir Şekilde Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(UpdateEmployeeDto updateEmployeeDto)
        {
            _emplyeeRepository.UpdateteEmployee(updateEmployeeDto);
            return Ok("Personel Başarıyla Güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var value = await _emplyeeRepository.GetEmployee(id);
            return Ok(value);
        }
    }
}
