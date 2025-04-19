using AutoMapper;
using TrackAndGo.Application.DTOs;
using TrackAndGo.Domain.Entities;

namespace TrackAndGo.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Hotel, GetHotelDto>();
            CreateMap<CreateHotelDto, Hotel>();
            CreateMap<CreatePointOfInterestDto, PointOfInterest>();
            CreateMap<PointOfInterest, GetPointOfInterestDto>();
            CreateMap<InterestImage, InterestImageDto>().ReverseMap();
        }
    }
}
