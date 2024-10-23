using RealEstateDapper.API.DTOs.ContactDtos;

namespace RealEstateDapper.API.Repositories.ContactRepositories
{
    public interface IContactRepository
    {
        Task<List<ResultContactDto>> GetAllContactAsync();
        Task<List<GetLast4ContactDto>> GetLast4Contact();
        Task<GetByIdContactDto> GetContact(int id);
        Task CreateteContact(CreateContactDto createContactDto);
        Task DeleteteContact(int id);
    }
}
