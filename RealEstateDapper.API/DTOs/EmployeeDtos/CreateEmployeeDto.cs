﻿namespace RealEstateDapper.API.DTOs.EmployeeDtos
{
    public class CreateEmployeeDto
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageUrl { get; set; }
    }
}
