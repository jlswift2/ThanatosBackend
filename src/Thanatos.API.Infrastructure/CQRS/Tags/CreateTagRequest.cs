using MediatR;
using Thanatos.API.Infrastructure.Data;

namespace Thanatos.API.Infrastructure.CQRS.Tags
{
    public class CreateTagRequest : IRequest<CreateTagRequestResponse>
    {
        public CreateTagRequest(CreateTagBody body)
        {
            Body = body;
        }
        public CreateTagBody Body { get; init; }
    }

    public record CreateTagBody
    {
        public string Name { get; init; }
    }
}
