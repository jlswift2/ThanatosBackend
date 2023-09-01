using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thanatos.API.Infrastructure.Data;

namespace Thanatos.API.Infrastructure.CQRS.Pages
{
    public class UpdatePageRequest : IRequest<UpdatePageRequestResponse>
    {
        public UpdatePageRequest(UpdatePageRoute route, UpdatePageBody body)
        {
            Route = route;
            Body = body;
        }

        public UpdatePageRoute Route { get; }
        public UpdatePageBody Body { get; }
    }

    public record UpdatePageRoute
    {
        public Guid Id { get; set; }
    }

    public record UpdatePageBody
    {
        public string Title { get; set; }
        public Category Category { get; set; }
    }
}
