using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackAndGo.Application.DTOs
{
    public class InterestImageDto
    {
        [Required]
        [Url(ErrorMessage = "ImageUrl must be a valid URL.")]
        [StringLength(500, ErrorMessage = "Image URL must not exceed 500 characters.")]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
