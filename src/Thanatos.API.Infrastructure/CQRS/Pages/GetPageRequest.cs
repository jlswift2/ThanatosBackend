using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thanatos.API.Infrastructure.CQRS.Pages
{
    public class GetPageRequest : IRequest<GetPageRequestResponse>
    {
        public GetPageRequest(GetPageRoute route)
        {
            Route = route;
        }

        public GetPageRoute Route { get; }
    }

    public record GetPageRoute
    {
        public Guid Id { get; set; }
    }
}
