﻿namespace RealEstateDapper.API.DTOs.SubFeatureDtos
{
    public class UpdateSubFeatureDto
    {
        public int SubFeatureId { get; set; }
        public string Icon { get; set; }
        public string TopTitle { get; set; }
        public string MainTitle { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
    }
}
