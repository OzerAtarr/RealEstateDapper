using Dapper;
using RealEstateDapper.API.DTOs.CategoryDtos;
using RealEstateDapper.API.DTOs.SubFeatureDtos;
using RealEstateDapper.API.Models.DapperContext;

namespace RealEstateDapper.API.Repositories.SubFatureRepositories
{
    public class SubFeatureRepository : ISubFeatureRepository
    {
        private readonly Context _context;
        public SubFeatureRepository(Context context)
        {
            _context = context;
        }

        public Task CreateSubFeature(CreateSubFeatureDto createSubFeatureDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSubFeature(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultSubFeatureDto>> GetAllSubFeatureAsync()
        {
            string query = "Select * From SubFeature";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultSubFeatureDto>(query);
                return values.ToList();
            }
        }

        public Task<GetByIDCategoryDto> GetSubFeature(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSubFeature(UpdateSubFeatureDto updateSubFeatureDto)
        {
            throw new NotImplementedException();
        }
    }
}
