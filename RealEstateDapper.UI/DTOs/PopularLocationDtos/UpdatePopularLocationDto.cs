﻿namespace RealEstateDapper.UI.DTOs.PopularLocationDtos
{
    public class UpdatePopularLocationDto
    {
        public int LocationID { get; set; }
        public string CityName { get; set; }
        public int PropertyCount { get; set; }
        public string ImageUrl { get; set; }
    }
}
