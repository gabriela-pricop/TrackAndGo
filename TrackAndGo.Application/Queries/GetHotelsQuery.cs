using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TrackAndGo.Application.Abstractions;
using TrackAndGo.Application.DTOs;
using TrackAndGo.Domain.Entities;

namespace TrackAndGo.Application.Queries
{
    public class GetHotelsQuery : IRequest<List<GetHotelDto>>
    {

    }

    public class GetHotelsQueryHandler : IRequestHandler<GetHotelsQuery, List<GetHotelDto>>
    {
        private readonly IGenericRepository<Hotel> _genericRepository;

        public GetHotelsQueryHandler(IGenericRepository<Hotel> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<List<GetHotelDto>> Handle(GetHotelsQuery request, CancellationToken cancellationToken)
        {
            var hotels = await _genericRepository
                .GetAll()
                .Include(x => x.City)
                    .ThenInclude(x => x.District)
                .Select(x => new GetHotelDto
                {
                    Name = x.Name,
                    Phone = x.Phone,
                    Latitude = x.Latitude,
                    Longitude = x.Longitude,
                    FullAddress = x.Address == null ? $"{x.City.Name}, {x.City.District.Name}" : $"{x.Address}, {x.City.Name}, {x.City.District.Name}"
                })
                .ToListAsync(cancellationToken);


            return hotels;
        }
    }
}
