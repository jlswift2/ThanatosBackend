using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thanatos.API.Infrastructure.CQRS.Pages
{
    public class DeletePageRequest : IRequest
    {
        public DeletePageRequest(DeletePageRoute route)
        {
            Route = route;
        }

        public DeletePageRoute Route { get; set; }
    }

    public record DeletePageRoute
    {
        public Guid Id { get; set; }
    }
}
