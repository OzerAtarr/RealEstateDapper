using Dapper;
using RealEstateDapper.API.DTOs.ContactDtos;
using RealEstateDapper.API.Models.DapperContext;

namespace RealEstateDapper.API.Repositories.ContactRepositories
{
    public class ContacctRepository : IContactRepository
    {
        private readonly Context _context;

        public ContacctRepository(Context context)
        {
            _context = context;
        }

        public Task CreateteContact(CreateContactDto createContactDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteteContact(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultContactDto>> GetAllContactAsync()
        {
            string query = "SELECT * FROM Contact";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultContactDto>(query);
                return values.ToList();
            }
        }

        public Task<GetByIdContactDto> GetContact(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GetLast4ContactDto>> GetLast4Contact()
        {
            string query = "SELECT * FROM Contact";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<GetLast4ContactDto>(query);
                return values.ToList();
            }
        }
    }
}
