using Dapper;
using RealEstateDapper.API.DTOs.AppUserDtos;
using RealEstateDapper.API.DTOs.CategoryDtos;
using RealEstateDapper.API.Models.DapperContext;

namespace RealEstateDapper.API.Repositories.AppUserRepositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly Context _context;
        public AppUserRepository(Context context)
        {
            _context = context;
        }

        public async Task<GetAppUserByProductIdDto> GetAppUserByProductId(int id)
        {
            string query = "Select * From AppUser Where UserId=@userId";
            var parameters = new DynamicParameters();
            parameters.Add("@userId", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<GetAppUserByProductIdDto>(query, parameters);
                return value;
            }
        }
    }
}
