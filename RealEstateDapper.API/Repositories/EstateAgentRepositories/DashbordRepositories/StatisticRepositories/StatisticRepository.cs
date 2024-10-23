using Dapper;
using RealEstateDapper.API.Models.DapperContext;

namespace RealEstateDapper.API.Repositories.EstateAgentRepositories.DashbordRepositories.StatisticRepositories
{
    public class StatisticRepository : IStatisticRepository
    {
        private readonly Context _context;

        public StatisticRepository(Context context)
        {
            _context = context;
        }

        public int AllProductCount()
        {
            string query = "Select Count(*) From Product ";
            using (var connection = _context.CreateConnection())
            {
                var value = connection.QueryFirstOrDefault<int>(query);
                return value;
            }
        }

        public int ProductCountByEmployeeId(int id)
        {
            string query = "Select Count(*) From Product WHERE AppUserId=@appUserId";
            var parameters = new DynamicParameters();
            parameters.Add("@appUserId", id);
            using (var connection = _context.CreateConnection())
            {
                var value = connection.QueryFirstOrDefault<int>(query, parameters);
                return value;
            }
        }

        public int ProductCountByStatusFalse(int id)
        {
            string query = "Select Count(*) From Product WHERE AppUserId=@appUserId And ProductStatus=0";
            var parameters = new DynamicParameters();
            parameters.Add("@appUserId", id);
            using (var connection = _context.CreateConnection())
            {
                var value = connection.QueryFirstOrDefault<int>(query, parameters);
                return value;
            }
        }

        public int ProductCountByStatusTrue(int id)
        {
            string query = "Select Count(*) From Product WHERE AppUserId=@appUserId And ProductStatus=1";
            var parameters = new DynamicParameters();
            parameters.Add("@appUserId", id);
            using (var connection = _context.CreateConnection())
            {
                var value = connection.QueryFirstOrDefault<int>(query, parameters);
                return value;
            }
        }
    }
}
