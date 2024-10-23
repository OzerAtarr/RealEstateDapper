using Dapper;
using RealEstateDapper.API.DTOs.ProductImageDtos;
using RealEstateDapper.API.Models.DapperContext;

namespace RealEstateDapper.API.Repositories.ProductImageRepositories
{
    public class ProductImageRepository : IProductImageRepository
    {
        private readonly Context _context;
        public ProductImageRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<GetProductImageByProductIdDto>> GetProductImageByProductId(int productId)
        {
            string query = "Select * From ProductImage WHERE ProductId=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", productId);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<GetProductImageByProductIdDto>(query, parameters);
                return values.ToList();
            }
        }
    }
}
