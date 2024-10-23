



using RealEstateDapper.API.DTOs.ProductDtos;

namespace RealEstateDapper.API.Repositories.EstateAgentRepositories.DashbordRepositories.LastProductsRepositories
{
    public interface ILast5ProductsRepository
    {
        Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductByEmployeeIdAsync(int id);
    }
}
