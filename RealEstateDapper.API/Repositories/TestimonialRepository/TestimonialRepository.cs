using Dapper;
using RealEstateDapper.API.DTOs.TestimonialDtos;
using RealEstateDapper.API.Models.DapperContext;

namespace RealEstateDapper.API.Repositories.TestimonialRepository
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly Context _context;
        public TestimonialRepository(Context context)
        {
            _context = context;
        }
       
        public async Task CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            string query = "insert into Testimonial (NameSurname,Title,Comment,Status) " +
                                            "VALUES (@nameSurname,@title,@comment,@status)";
            var parameters = new DynamicParameters();
            parameters.Add("@nameSurname", createTestimonialDto.NameSurname);
            parameters.Add("@title", createTestimonialDto.Title);
            parameters.Add("@comment", createTestimonialDto.Comment);
            parameters.Add("@status", true);
            using(var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteTestimonial(int id)
        {
            string query = "DELETE FROM Testimonial " +
                "WHERE TestimonialID=@testimonialID";
            var parameters = new DynamicParameters();
            parameters.Add("@testimonialID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultTestimonialDto>> GetAllTestimonialAsync()
        {
            string query = "SELECT * FROM Testimonial";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultTestimonialDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDTestimonialDto> GetTestimonial(int id)
        {
            string query = "SELECT * FROM Testimonial " +
                "WHERE TestimonialID=@testimonialID";
            var parameters = new DynamicParameters();
            parameters.Add("@testimonialID", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<GetByIDTestimonialDto>(query, parameters);
                return value;
            }
        }

        public async Task UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            string query = "UPDATE Testimonial " +
                "SET NameSurname=@nameSurname,Title=@title,Comment=@comment,Status=@status " +
                "WHERE TestimonialID=@testimonialID";
            var parameters = new DynamicParameters();
            parameters.Add("@nameSurname", updateTestimonialDto.NameSurname);
            parameters.Add("@title", updateTestimonialDto.Title);
            parameters.Add("@comment", updateTestimonialDto.Comment);
            parameters.Add("@status", updateTestimonialDto.Status);
            parameters.Add("@testimonialID", updateTestimonialDto.TestimonialID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
