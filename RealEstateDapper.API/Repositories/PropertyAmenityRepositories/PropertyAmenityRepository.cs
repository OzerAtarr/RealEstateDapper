using Dapper;
using RealEstateDapper.API.DTOs.PropertyAmenityDtos;
using RealEstateDapper.API.Models.DapperContext;

namespace RealEstateDapper.API.Repositories.PropertyAmenityRepositories
{
    public class PropertyAmenityRepository : IPropertyAmenityRepository
    {
        private readonly Context _context;
        public PropertyAmenityRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultPropertyAmenityByStatusTrueDto>> GetPropertyAmenityByStatusTrue(int id)
        {
            string query = @"Select PropertyAmenityID, Title From PropertyAmenity
                                    Inner Join Amenity 
                                    On Amenity.AmenityId=PropertyAmenity.AmenityId
                                    Where PropertyId = propertyId AND Status=1";
            var parameters = new DynamicParameters();
            parameters.Add("@propertyId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPropertyAmenityByStatusTrueDto>(query);
                return values.ToList();
            }
        }
    }
}
