using Dapper;
using RealEstateDapper.API.DTOs.ProductDtos;
using RealEstateDapper.API.Models.DapperContext;

namespace RealEstateDapper.API.Repositories.EstateAgentRepositories.DashbordRepositories.LastProductsRepositories
{
    public class Last5ProductsRepository : ILast5ProductsRepository
    {
        private readonly Context _context;

        public Last5ProductsRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductByEmployeeIdAsync(int id)
        {
            string query = "Select TOP(5) ProductID, Title, Price, District, ProductCategory, CategoryName, AdvertisementDate City FROM Product Inner Join Category On Product.ProductCategory=Category.CategoryID WHERE AppUserId=@appUserId Order By ProductID DESC";
            var parameters = new DynamicParameters();
            parameters.Add("@appUserId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultLast5ProductWithCategoryDto>(query, parameters);
                return values.ToList();
            }
        }
    }
}
