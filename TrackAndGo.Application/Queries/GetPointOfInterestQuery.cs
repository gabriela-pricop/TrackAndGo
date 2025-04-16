using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TrackAndGo.Application.Abstractions;
using TrackAndGo.Application.DTOs;
using TrackAndGo.Domain.Entities;

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
                .Include(x => x.Images)
                .FirstAsync(x => x.Id == request.Id, cancellationToken);

            return _mapper.Map<GetPointOfInterestDto>(pointOfInterest);
        }
    }
}