using System.ComponentModel.DataAnnotations;
using TrackAndGo.Shared.Enums;

namespace TrackAndGo.Application.DTOs
{
    public class PointsOfInterestDto 
    {
        [Required]
        [Url(ErrorMessage = "ImageUrl must be a valid URL.")]
        [StringLength(500, ErrorMessage = "Image URL must not exceed 500 characters.")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        [StringLength(255, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 255 characters.")]
        public string Name { get; set; } = string.Empty;

        [Required]
        public InterestTypeEnum Type { get; set; }

        [StringLength(100, ErrorMessage = "Address must not exceed 100 characters.")]
        public string FullAddress { get; set; } = string.Empty;
    }
}
