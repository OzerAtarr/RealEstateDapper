namespace RealEstateDapper.API.Models.DTOs.ProductDto
{
    public class ResultProductDto
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Adress { get; set; }


        //public int EmployeeID { get; set; }
        public int ProductCategory { get; set; } 
    }
}
