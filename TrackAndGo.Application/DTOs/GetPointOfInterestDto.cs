using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackAndGo.Shared.Enums;

namespace TrackAndGo.Application.DTOs
{
    public class GetPointOfInterestDto
    {
        [Required]
        [StringLength(255, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 255 characters.")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "Description must be between 10 and 1000 characters.")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(-90.0, 90.0, ErrorMessage = "Latitude must be between -90 and 90.")]
        public double Latitude { get; set; }

        [Required]
        [Range(-180.0, 180.0, ErrorMessage = "Longitude must be between -180 and 180.")]
        public double Longitude { get; set; }

        [Required]
        [Url(ErrorMessage = "ImageUrl must be a valid URL.")]
        [StringLength(500, ErrorMessage = "Image URL must not exceed 500 characters.")]
        public string ImageUrl { get; set; } = string.Empty;

        [Url(ErrorMessage = "WebsiteUrl must be a valid URL.")]
        [StringLength(500, ErrorMessage = "Website URL must not exceed 500 characters.")]
        public string? WebsiteUrl { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "InterestTypeEnum must be a positive number.")]
        public InterestTypeEnum Type { get; set; }


        [StringLength(100, ErrorMessage = "Address must not exceed 100 characters.")]
        public string FullAddress { get; set; } = string.Empty;

        public List<InterestImageDto> Images { get; set; } = [];
    }
}
