using MediatR;
using Microsoft.EntityFrameworkCore;
using TrackAndGo.Application.Abstractions;
using TrackAndGo.Application.DTOs;
using TrackAndGo.Domain.Entities;
using TrackAndGo.Shared.Enums;
using TrackAndGo.Shared.Extensions;

namespace TrackAndGo.Application.Queries
{
    public class GetPointsOfInterestsQuery : IRequest<PaginatedResult<PointsOfInterestDto>>
    {
        public InterestTypeEnum? Type { get; set; }
        public string? SearchTerm {  get; set; }
        public int PageSize { get; set; } = 10;
        public int PageNumber { get; set; } = 1;

    }

    public class GetPointsOfInterestQueryHandler : IRequestHandler<GetPointsOfInterestsQuery, PaginatedResult<PointsOfInterestDto>>
    {
        private readonly IGenericRepository<PointOfInterest> _genericRepository;

        public GetPointsOfInterestQueryHandler(IGenericRepository<PointOfInterest> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<PaginatedResult<PointsOfInterestDto>> Handle(GetPointsOfInterestsQuery request, CancellationToken cancellationToken)
        {
            var query = _genericRepository.GetAll();

            if (request.Type is not null)
            {
                query = query.Where(x => x.InterestTypeId == request.Type.GetGuid());
            }

            if (!string.IsNullOrWhiteSpace(request.SearchTerm))
            {
                query = query.Where(x => x.Name.Contains(request.SearchTerm));
            }

            var totalCount = query.CountAsync(cancellationToken).Result;

            var pointsOfInterest = await _genericRepository
                .GetAllPaged(request.PageNumber, request.PageSize)
                .Include(x => x.City)
                    .ThenInclude(city => city.District)
                .Select(x => new PointsOfInterestDto
                {
                    Name = x.Name,
                    Address = $"{x.City.Name}, {x.City.District.Name}",
                    ImageUrl = x.ImageUrl
                })
                .ToListAsync(cancellationToken);

            return new PaginatedResult<PointsOfInterestDto>(
                totalCount, 
                request.PageNumber, 
                request.PageSize,
                pointsOfInterest);
        }
    }
}
