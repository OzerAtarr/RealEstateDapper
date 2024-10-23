using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper.API.DTOs.ToDoListDtos;
using RealEstateDapper.API.Repositories.ToDoListRepositories;

namespace RealEstateDapper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListsController : ControllerBase
    {
        private readonly IToDoListRepository _toDoListRepository;
        public ToDoListsController(IToDoListRepository toDoListRepository)
        {
            _toDoListRepository = toDoListRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ToDoListList()
        {
            var values = await _toDoListRepository.GetAllToDoListAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateToDoList(CreateToDoListDto createToDoListDto)
        {
            _toDoListRepository.CreateteToDoList(createToDoListDto);
            return Ok("Yapılacaklar Listesi Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteToDoList(int id)
        {
            _toDoListRepository.DeleteteToDoList(id);
            return Ok("Yapılacaklar Listesi Başarılı Bir Şekilde Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateToDoList(UpdateToDoListDto updateToDoListDto)
        {
            _toDoListRepository.UpdateteToDoList(updateToDoListDto);
            return Ok("Yapılacaklar Listesi Başarıyla Güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetToDoList(int id)
        {
            var value = await _toDoListRepository.GetToDoList(id);
            return Ok(value);
        }
    }
}
