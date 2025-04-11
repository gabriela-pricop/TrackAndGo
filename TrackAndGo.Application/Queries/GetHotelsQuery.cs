using AutoMapper;
using MediatR;
using TrackAndGo.Application.Abstractions;
using TrackAndGo.Application.DTOs;
using TrackAndGo.Domain.Entities;

namespace TrackAndGo.Application.Queries
{
    public class GetHotelsQuery : IRequest<List<HotelDto>>
    {

    }

    public class GetHotelsQueryHandler : IRequestHandler<GetHotelsQuery, List<HotelDto>>
    {
        private readonly IGenericRepository<Hotel> _genericRepository;
        private readonly IMapper _mapper;

        public GetHotelsQueryHandler(IGenericRepository<Hotel> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public Task<List<HotelDto>> Handle(GetHotelsQuery request, CancellationToken cancellationToken)
        {
            var hotels = _genericRepository.GetAll().ToList();

            if (hotels.Count != 0)
            {
                var hotelDtos = _mapper.Map<List<HotelDto>>(hotels);
                return Task.FromResult(hotelDtos);
            }

            return Task.FromResult(new List<HotelDto>());
        }
    }
}
