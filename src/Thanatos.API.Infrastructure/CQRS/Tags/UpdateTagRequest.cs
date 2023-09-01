using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thanatos.API.Infrastructure.Data;

namespace Thanatos.API.Infrastructure.CQRS.Tags
{
    public class UpdateTagRequest : IRequest<UpdateTagRequestResponse>
    {
        public UpdateTagRequest(UpdateTagRoute route, UpdateTagBody body)
        {
            Route = route;
            Body = body;
        }

        public UpdateTagRoute Route { get; init; }
        public UpdateTagBody Body { get; init; }
    }

    public record UpdateTagRoute
    {
        public Guid Id { get; init; }
    }

    public record UpdateTagBody
    {
        public string Name { get; init; }
    }
}
