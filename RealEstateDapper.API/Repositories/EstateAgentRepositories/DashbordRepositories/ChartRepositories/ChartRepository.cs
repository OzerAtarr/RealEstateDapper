using Dapper;
using RealEstateDapper.API.DTOs.CategoryDtos;
using RealEstateDapper.API.DTOs.ChartDtors;
using RealEstateDapper.API.Models.DapperContext;

namespace RealEstateDapper.API.Repositories.EstateAgentRepositories.DashbordRepositories.ChartRepositories
{
    public class ChartRepository : IChartRepository
    {
        private readonly Context _context;
        public ChartRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultChartDto>> Get5CityForChart()
        {
            string query = @"SELECT TOP (5) City, COUNT(*) AS CityCount
                                                            FROM Product
                                                            GROUP BY City
                                                            ORDER BY CityCount DESC";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultChartDto>(query);
                return values.ToList();
            }
        }
    }
}
