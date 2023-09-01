using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thanatos.API.Infrastructure.CQRS.Tags
{
    public class DeleteTagRequest : IRequest
    {
        public DeleteTagRequest(DeleteTagRoute route)
        {
            Route = route;
        }

        public DeleteTagRoute Route { get; init; }
    }

    public record DeleteTagRoute
    {
        public Guid Id { get; init; }
    }
}
