using System.ComponentModel.DataAnnotations;

namespace TrackAndGo.Application.DTOs
{
    public class GetHotelDto
    {
        [Required]
        [StringLength(255, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 255 characters.")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Phone(ErrorMessage = "Invalid phone number format.")]
        [StringLength(15, ErrorMessage = "Phone number must not exceed 15 characters.")]
        public string Phone { get; set; } = string.Empty;

        [Required]
        [Range(-90.0, 90.0, ErrorMessage = "Latitude must be between -90 and 90 degrees.")]
        public double Latitude { get; set; }

        [Required]
        [Range(-180.0, 180.0, ErrorMessage = "Longitude must be between -180 and 180 degrees.")]
        public double Longitude { get; set; }

        [StringLength(100, ErrorMessage = "Address must not exceed 100 characters.")]
        public string? FullAddress { get; set; }
    }
}
