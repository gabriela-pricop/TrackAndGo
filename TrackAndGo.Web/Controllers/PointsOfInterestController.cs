using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrackAndGo.Application.DTOs;
using TrackAndGo.Application.Queries;
using TrackAndGo.Shared.Enums;

namespace TrackAndGo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PointsOfInterestController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PointsOfInterestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet] 
        public async Task<IActionResult> GetPointsOfInterest(
        [FromQuery] List<InterestTypeEnum>? types, 
        [FromQuery] string? searchTerm,           
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 10)            
        {
            if (pageNumber <= 0 || pageSize <= 0)
            {
                return BadRequest("Page number and page size must be greater than 0.");
            }

            var query = new GetPointsOfInterestsQuery
            {
                Types = types ?? new List<InterestTypeEnum>(), 
                SearchTerm = searchTerm,
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            var result = await _mediator.Send(query);

            return Ok(result);
        }
    }
}
