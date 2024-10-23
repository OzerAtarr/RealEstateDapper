using Dapper;
using RealEstateDapper.API.DTOs.ToDoListDtos;
using RealEstateDapper.API.Models.DapperContext;

namespace RealEstateDapper.API.Repositories.ToDoListRepositories
{
    public class ToDoListRepository : IToDoListRepository
    {
        private readonly Context _context;

        public ToDoListRepository(Context context)
        {
            _context = context;
        }

        public async Task CreateteToDoList(CreateToDoListDto createToDoListDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteteToDoList(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultToDoListDto>> GetAllToDoListAsync()
        {
            string query = "Select * From ToDoList";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultToDoListDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDToDoListDto> GetToDoList(int id)
        {
            string query = "Select * From ToDoList " +
                           "Where ToDoListID=@toDoListID";
            var parameters = new DynamicParameters();
            parameters.Add("@toDoListID", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<GetByIDToDoListDto>(query, parameters);
                return value;
            }
        }

        public Task UpdateteToDoList(UpdateToDoListDto updateToDoListDto)
        {
            throw new NotImplementedException();
        }
    }
}
