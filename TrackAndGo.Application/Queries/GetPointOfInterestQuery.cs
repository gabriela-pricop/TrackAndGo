using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TrackAndGo.Application.Abstractions;
using TrackAndGo.Application.DTOs;
using TrackAndGo.Application.Exceptions;
using TrackAndGo.Domain.Entities;
using TrackAndGo.Shared.Enums;

namespace TrackAndGo.Application.Queries
{
    public class GetPointOfInterestQuery : IRequest<GetPointOfInterestDto>
    {
        public int Id { get; set; }
    }

    public class GetPointOfInterestQueryHandler : IRequestHandler<GetPointOfInterestQuery, GetPointOfInterestDto>
    {
        private readonly IGenericRepository<PointOfInterest> _genericRepository;
        private readonly IMapper _mapper;

        public GetPointOfInterestQueryHandler(IGenericRepository<PointOfInterest> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<GetPointOfInterestDto> Handle(GetPointOfInterestQuery request, CancellationToken cancellationToken)
        {
            var pointOfInterest = await _genericRepository
                .GetAll()
                .Include(x => x.Images) // Include related images
                .Include(x => x.City) // Include related city
                    .ThenInclude(city => city.District) // Include related district
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (pointOfInterest is null)
            {
                throw new EntityNotFoundException(typeof(PointOfInterest), request.Id);
            }

            // Map the entity to the DTO
            var dto = _mapper.Map<GetPointOfInterestDto>(pointOfInterest);

            // Manually construct the Address property
            dto.Address = $"{pointOfInterest.City.Name}, {pointOfInterest.City.District.Name}";

            // Map the InterestTypeId to the Type property
            dto.Type = (InterestTypeEnum)pointOfInterest.InterestTypeId;

            return dto;
        }
    }
}