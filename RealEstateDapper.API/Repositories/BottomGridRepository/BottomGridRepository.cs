using Dapper;
using RealEstateDapper.API.DTOs.BottomGridDtos;
using RealEstateDapper.API.Models.DapperContext;

namespace RealEstateDapper.API.Repositories.BottomGridRepository
{
    public class BottomGridRepository : IBottomGridRepository
    {
        private readonly Context _context;

        public BottomGridRepository(Context context)
        {
            _context = context;
        }

        public async void CreateBottomGrid(CreateBottomGridDto createBottomGridDto)
        {
            string query = "insert into BottomGrid (Icon,Title,Description)" +
                                           "VALUES (@icon,@title,@description)";
            var parameters = new DynamicParameters();
            parameters.Add("@icon", createBottomGridDto.Icon);
            parameters.Add("@title", createBottomGridDto.Title);
            parameters.Add("@description", createBottomGridDto.Description);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }

        }

        public async void DeleteBottomGrid(int id)
        {
            string query = "DELETE FROM BottomGrid " +
                                   "WHERE @BottomGridID=@bottomGridId";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridId", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultBottomGridDto>> GetAllBottomGridAsync()
        {
            string query = "SELECT * FROM BottomGrid";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultBottomGridDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetBottomGridDto> GetBottomGrid(int id)
        {
            string query = "SELECT * FROM BottomGrid " +
                "WHERE BottomGridID=@bottomGridId";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridId", id);

            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<GetBottomGridDto>(query, parameters);
                return value;
            }
        }

        public async void UpdateBottomGrid(UpdateBottomGridDto updateButtomGridDto)
        {
            string query = "UPDATE BottomGrid " +
                                "SET Icon=@icon,Title@title,Description@description" +
                                "WHERE BottomGridID=@bottomGridId";
            
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridId", updateButtomGridDto.BottomGridID);
            parameters.Add("@icon", updateButtomGridDto.Icon);
            parameters.Add("@title", updateButtomGridDto.Title);
            parameters.Add("@description", updateButtomGridDto.Description);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
