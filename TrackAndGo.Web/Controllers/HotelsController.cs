using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TrackAndGo.Application.Queries;

namespace TrackAndGo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class HotelsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HotelsController(IMediator mediator) 
        { 
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetHotels()
        {
            var query = new GetHotelsQuery();

            var result = await _mediator.Send(query);

            return Ok(result);
        }
    }
}
