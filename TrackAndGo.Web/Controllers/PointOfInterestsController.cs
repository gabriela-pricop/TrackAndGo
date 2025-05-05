using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrackAndGo.Application.Abstractions;
using TrackAndGo.Application.Commands;
using TrackAndGo.Application.DTOs;
using TrackAndGo.Application.Queries;
using TrackAndGo.Domain.Entities;
using TrackAndGo.Shared.Enums;

namespace TrackAndGo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class PointOfInterestsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PointOfInterestsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPointOfInterest(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid ID provided.");
            }

            var query = new GetPointOfInterestQuery { Id = id };

            var result = await _mediator.Send(query);

            if (result == null)
            {
                return NotFound($"Point of Interest with ID {id} not found.");
            }
            return Ok(result);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddPointOfInterest([FromBody] CreatePointOfInterestDto pointOfInterestDto)
        {
            if (pointOfInterestDto == null)
            {
                return BadRequest("Point of Interest data is required.");
            }

            var command = new AddPointOfInterestCommand { PointOfInterest = pointOfInterestDto };

            var result = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetPointOfInterest), new { id = result }, pointOfInterestDto);
        }
    }
}
