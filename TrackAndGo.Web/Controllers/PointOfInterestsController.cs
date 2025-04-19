using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
