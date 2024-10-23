using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper.API.DTOs.ContactDtos;
using RealEstateDapper.API.Repositories.ContactRepositories;

namespace RealEstateDapper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactRepository _contactRepository;

        public ContactsController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        [HttpGet("GetAllContactAsync")]
        public async Task<IActionResult> GetAllContactAsync()
        {
            var values = await _contactRepository.GetAllContactAsync();
            return Ok(values);
        }

        [HttpGet("GetLast4Contact")]
        public async Task<IActionResult> GetLast4Contact()
        {
            var values = await _contactRepository.GetLast4Contact();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactDto createContactDto)
        {
            _contactRepository.CreateteContact(createContactDto);
            return Ok("Personel Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            _contactRepository.DeleteteContact(id);
            return Ok("Personel Başarılı Bir Şekilde Silindi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetContact(int id)
        {
            var value = await _contactRepository.GetContact(id);
            return Ok(value);
        }
    }
}
