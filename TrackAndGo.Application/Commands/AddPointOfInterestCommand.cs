using AutoMapper;
using MediatR;
using TrackAndGo.Application.Abstractions;
using TrackAndGo.Application.DTOs;
using TrackAndGo.Domain.Entities;

namespace TrackAndGo.Application.Commands
{
    public class AddPointOfInterestCommand : IRequest<int>
    {
        public CreatePointOfInterestDto PointOfInterest { get; set; } = new();
    }

    public class AddPointOfInterestCommandHandler : IRequestHandler<AddPointOfInterestCommand, int>
    {
        private readonly IGenericRepository<PointOfInterest> _genericRepository;
        private readonly IMapper _mapper;

        public AddPointOfInterestCommandHandler(IGenericRepository<PointOfInterest> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(AddPointOfInterestCommand request, CancellationToken cancellationToken)
        {
            var pointOfInterest = _mapper.Map<PointOfInterest>(request.PointOfInterest);

            await _genericRepository.AddAsync(pointOfInterest, cancellationToken);
            await _genericRepository.SaveAsync(cancellationToken);

            return pointOfInterest.Id;
        }
    }
}