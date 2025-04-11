using AutoMapper;
using TrackAndGo.Application.DTOs;
using TrackAndGo.Domain.Entities;

namespace TrackAndGo.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Hotel, HotelDto>().ReverseMap();
        }
    }
}
