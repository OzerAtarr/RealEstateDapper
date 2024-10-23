using RealEstateDapper.API.DTOs.ProductImageDtos;

namespace RealEstateDapper.API.Repositories.ProductImageRepositories
{
    public interface IProductImageRepository
    {
        Task<List<GetProductImageByProductIdDto>> GetProductImageByProductId(int productId);
    }
}
