﻿namespace RealEstateDapper.API.DTOs.PopularLocationDtos
{
    public class GetPopularLocationDto
    {
        public int LocationID { get; set; }
        public string CityName { get; set; }
        public int PropertyCount { get; set; }
        public string ImageUrl { get; set; }
    }
}
