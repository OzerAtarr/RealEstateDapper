using Dapper;
using RealEstateDapper.API.DTOs.EmployeeDtos;
using RealEstateDapper.API.Models.DapperContext;

namespace RealEstateDapper.API.Repositories.EmplyeeRepository
{
    public class EmplyeeRepository : IEmplyeeRepository
    {
        private readonly Context _context;
        public EmplyeeRepository(Context context)
        {
            _context = context;
        }
        public async Task CreateteEmployee(CreateEmployeeDto createEmployeeDto)
        {
            string query = "Insert into Employee (Name, Title, Mail, PhoneNumber, ImageUrl, Status) VALUES (@name, @title, @mail, @phoneNumber, @imageUrl, @status)";
            var parameters = new DynamicParameters();
            parameters.Add("@name", createEmployeeDto.Name);
            parameters.Add("@title", createEmployeeDto.Title);
            parameters.Add("@mail", createEmployeeDto.Mail);
            parameters.Add("@phoneNumber", createEmployeeDto.PhoneNumber);
            parameters.Add("@imageUrl", createEmployeeDto.ImageUrl);
            parameters.Add("@status", true);

            using(var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteteEmployee(int id)
        {
            string query = "DELETE from Employee WHERE EmployeeID=@employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultEmployeeDto>> GetAllEmployeeAsync()
        {
            string query = "SELECT * FROM Employee";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultEmployeeDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDEmployeeDto> GetEmployee(int id)
        {
            string query = "SELECT * FROM Employee " +
                "WHERE EmployeeID=@employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryFirstOrDefaultAsync<GetByIDEmployeeDto>(query, parameters);
                return value;
            }
        }

        public async Task UpdateteEmployee(UpdateEmployeeDto updateEmployeeDto)
        {
            string query = "UPDATE Employee " +
                "SET Name=@name, Title=@title, Mail=@mail, PhoneNumber=@phoneNumber, ImageUrl=@imageUrl, Status=@status " +
                "WHERE EmployeeID=@employeeID";

            var parameters = new DynamicParameters();
            parameters.Add("@name", updateEmployeeDto.Name);
            parameters.Add("@title", updateEmployeeDto.Title);
            parameters.Add("@mail", updateEmployeeDto.Mail);
            parameters.Add("@phoneNumber", updateEmployeeDto.PhoneNumber);
            parameters.Add("@imageUrl", updateEmployeeDto.ImageUrl);
            parameters.Add("@status", updateEmployeeDto.Status);
            parameters.Add("@employeeID", updateEmployeeDto.EmployeeID);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
