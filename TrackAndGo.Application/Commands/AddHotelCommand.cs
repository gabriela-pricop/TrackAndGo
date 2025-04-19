using AutoMapper;
using MediatR;
using TrackAndGo.Application.Abstractions;
using TrackAndGo.Application.DTOs;
using TrackAndGo.Domain.Entities;

namespace TrackAndGo.Application.Commands
{
    public class AddHotelCommand : IRequest<Unit>
    {
        public CreateHotelDto Hotel { get; set; } = new();
    }

    public class AddHotelCommandHandler : IRequestHandler<AddHotelCommand, Unit>
    {
        private readonly IGenericRepository<Hotel> _hotelRepository;
        private readonly IMapper _mapper;

        public AddHotelCommandHandler(IGenericRepository<Hotel> hotelRepository, IMapper mapper)
        {
            _hotelRepository = hotelRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(AddHotelCommand request, CancellationToken cancellationToken)
        {
            var hotel = _mapper.Map<Hotel>(request.Hotel);

            await _hotelRepository.AddAsync(hotel, cancellationToken);
            return Unit.Value;
        }
    }
}
