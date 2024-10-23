using Dapper;
using RealEstateDapper.API.DTOs.ProductDetailDtos;
using RealEstateDapper.API.DTOs.ProductDtos;
using RealEstateDapper.API.Models.DapperContext;

namespace RealEstateDapper.API.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;
        public ProductRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "Select * From Product";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync()
        {
            string query = "Select ProductID,Title,Price,City,District,CategoryName,CoverImage,Type,Address, DealOfTheDay, SlugUrl From Product inner join Category on Product.ProductCategory=Category.CategoryID";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync()
        {
            string query = "Select TOP(5) ProductID, Title, Price, District, ProductCategory, CategoryName, AdvertisementDate, City FROM Product Inner Join Category On Product.ProductCategory=Category.CategoryID WHERE Type='Kiralık' Order By ProductID DESC";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultLast5ProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertListByEmployeeAsyncByTrue(int id)
        {
            string query = "Select ProductID,Title,Price,City,District,CategoryName,CoverImage,Type,Address, DealOfTheDay From Product inner join Category on Product.ProductCategory=Category.CategoryID WHERE AppUserId=@appUserId AND ProductStatus=1";
            var parameters = new DynamicParameters();
            parameters.Add("appUserId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductAdvertListWithCategoryByEmployeeDto>(query, parameters);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertListByEmployeeAsyncByFalse(int id)
        {
            string query = "Select ProductID,Title,Price,City,District,CategoryName,CoverImage,Type,Address, DealOfTheDay From Product inner join Category on Product.ProductCategory=Category.CategoryID WHERE AppUserId=@appUserId AND ProductStatus=0";
            var parameters = new DynamicParameters();
            parameters.Add("appUserId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductAdvertListWithCategoryByEmployeeDto>(query, parameters);
                return values.ToList();
            }
        }
        public async Task ProductDealOfTheDayStatusChangeToFalse(int id)
        {
            string query = "Update Product Set DealOfTheDay=@dealOfTheDay WHERE ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("productID", id);
            parameters.Add("dealOfTheDay", 0);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task ProductDealOfTheDayStatusChangeToTrue(int id)
        {
            string query = "Update Product Set DealOfTheDay=@dealOfTheDay WHERE ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("productID", id);
            parameters.Add("dealOfTheDay", 1);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task CreateProduct(CreateProductDto createProductDto)
        {
            string query = @"Insert into Product (Title, Price, City, District, CoverImage, Address, Description, Type, DealOfTheDay, AdverTisementDate, ProductStatus, ProductCategory, EmployeeID)
                                          values (@title, @price, @city, @district, @coverImage, @address, @description, @type, @dealOfTheDay, @adverTisementDate, @productStatus, @productCategory, @appUserID)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", createProductDto.Title);
            parameters.Add("@price", createProductDto.Price);
            parameters.Add("@city", createProductDto.City);
            parameters.Add("@district", createProductDto.District);
            parameters.Add("@coverImage", createProductDto.CoverImage);
            parameters.Add("@address", createProductDto.Address);
            parameters.Add("@description", createProductDto.Description);
            parameters.Add("@type", createProductDto.Type);
            parameters.Add("@dealOfTheDay", createProductDto.DealOfTheDay);
            parameters.Add("@adverTisementDate", createProductDto.AdvertisementDate);
            parameters.Add("@productStatus", createProductDto.ProductStatus);
            parameters.Add("@productCategory", createProductDto.ProductCategory);
            parameters.Add("@appUserID", createProductDto.EmployeeID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<GetProductByProductIdDto> GetProductByProductId(int id)
        {
            string query = "Select ProductID,Title,Price,City,District,CategoryName,CoverImage,Type,Address, DealOfTheDay, AdvertisementDate, SlugUrl, Description From Product inner join Category on Product.ProductCategory=Category.CategoryID WHERE ProductId=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<GetProductByProductIdDto>(query, parameters);
                return value;
            }
        }

        public async Task<GetProductDetailByIdDto> GetProductDetailByProductId(int productId)
        {
            string query = "Select * From ProductDetails WHERE ProductId=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", productId);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<GetProductDetailByIdDto>(query, parameters);
                return value;
            }
        }

        public async Task<List<ResultProductWithSearchListDto>> ResultProductWithSearchList(string searchValue, int propertyCategoryId, string city)
        {
            string query = "Select * From Product Where Title like '%" + searchValue + "%' AND ProductCategory=@propertyCategoryId AND City=@city";
            var parameters = new DynamicParameters();
            parameters.Add("@searchKeyValue", searchValue);
            parameters.Add("@propertyCategoryId", propertyCategoryId);
            parameters.Add("@city", city);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithSearchListDto>(query, parameters);
                return values.ToList();
            }
        }

		public async Task<List<ResultProductWithCategoryDto>> GetProductByDealOfThDayTrueWithCategoryAsync()
		{
			string query = "Select ProductID,Title,Price,City,District,CategoryName,CoverImage,Type,Address, DealOfTheDay From Product inner join Category on Product.ProductCategory=Category.CategoryID WHERE DealOfTheDay=@dealOfTheDay";
            var parameters = new DynamicParameters();
            parameters.Add("@dealOfTheDay", 1);
            using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query,parameters);
				return values.ToList();
			}
		}

        public async Task<List<ResultLast3ProductWithCategoryDto>> GetLast3ProductAsync()
        {
            string query = "Select TOP(3) ProductID, Title, Price, District,Description, ProductCategory, CategoryName,CoverImage, AdvertisementDate ,City FROM Product Inner Join Category On Product.ProductCategory=Category.CategoryID WHERE Type='Kiralık' Order By ProductID DESC";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultLast3ProductWithCategoryDto>(query);
                return values.ToList();
            }
        }
    }
}
