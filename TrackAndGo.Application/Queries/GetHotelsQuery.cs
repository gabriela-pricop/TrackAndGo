using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackAndGo.Application.Queries
{
    public class GetHotelsQuery : IRequest
    {
    }

    public class GetHotelsQueryHandler : IRequestHandler<GetHotelsQuery>
    {
        public Task Handle(GetHotelsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
