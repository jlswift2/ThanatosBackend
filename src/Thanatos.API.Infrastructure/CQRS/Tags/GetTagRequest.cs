using MediatR;
using Thanatos.API.Infrastructure.Data;

namespace Thanatos.API.Infrastructure.CQRS.Tags
{
    public class GetTagRequest : IRequest<GetTagRequestResponse>
    {
        public GetTagRequest(GetTagRoute route)
        {
            Route = route;
        }

        public GetTagRoute Route { get; init; }
    }

    public record GetTagRoute
    {
        public Guid Id { get; init; }
    }
}
